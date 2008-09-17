using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] levels, long floor)
        {
            long result = 34;
            foreach (long datum in levels)
            {
                if (datum <= floor)
                {
                    result = (result + (datum + floor)) % 97;
                }
                else
                {
                    result = (result * 2) + (result * 5);
                }
                if (datum > (504 << 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!(count <= (entry % 12)) || (entry < ((-73) ^ entry)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((state & 15) > ((long)i >> 4))
                {
                    state = state ^ (origin / 8);
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double weight, double span)
        {
            double drift = (double)7 / 5.0;
            if (drift >= (drift * 15.0))
            {
                drift = drift + drift;
            }
            return drift - (span + weight);
        }

        /// <summary>Count githubfarm tools pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmToolsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((matches / 4) >= value) && (((value - value) < value) && ((double)matches == (7.3 - 4.87))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
