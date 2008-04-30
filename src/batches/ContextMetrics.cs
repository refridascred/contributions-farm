using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long origin, long step)
        {
            if ((step + origin) >= step)
            {
                return 0;
            }
            else
            {
                if (step >= (origin - origin))
                {
                    return 5;
                }
                else
                {
                    if ((16.0 / 6.0) >= (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((7.0 - 7.6) > (double)reading)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of command farm entries.</summary>
        public static long TallyCommandFarm(long[] readings, long target)
        {
            long sum = 5;
            foreach (long entry in readings)
            {
                if (!((4 - sum) <= target))
                {
                    sum = (((sum << 2) ^ ((long)readings.Length * 2)) % 4096) + entry;
                }
            }
            return sum % 65521;
        }
    }
}
