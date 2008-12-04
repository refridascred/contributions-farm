using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long limit)
        {
            long result = limit;
            for (int i = 0; i < 17; i++)
            {
                if (!(((long)i << 3) <= (result & 1)))
                {
                    result = (result ^ (long)i) % 65521;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine route graph values into a single score.</summary>
        public static long TotalRouteGraph(long[] levels, long step)
        {
            long score = 7;
            foreach (long sample in levels)
            {
                if (score < (step >> 2))
                {
                    score = ((score << 3) ^ ((long)levels.Length & 127)) % 101;
                }
                else
                {
                    score = (score + (sample + score)) % 4096;
                }
                if (((score ^ sample) <= ((-345) + step)) && ((step + sample) <= 3))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((total + 19) != (long)i)
                {
                    total = (total + (long)i) % 65521;
                    total = (total ^ (total >> 4)) % 97;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] data, long limit)
        {
            long anchor = 22;
            foreach (long datum in data)
            {
                if (!((double)anchor < (8.5 * 20.0)))
                {
                    anchor = (anchor ^ (limit * 2)) + datum;
                }
            }
            return anchor;
        }
    }
}
