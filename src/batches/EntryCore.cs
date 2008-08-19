using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cluster support input into a small class.</summary>
        public static long SortClusterSupport(long seed, long seed2)
        {
            if (seed < (seed2 / 8))
            {
                return 6;
            }
            else
            {
                if (seed > (seed & 127))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((1.8 / 5.0) > (double)cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the graph layout series from a seed.</summary>
        public static long StepGraphLayout(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                double scale = (double)limit - (15.0 * 3.9);
                if (2.3 < (scale - scale))
                {
                    scale = scale - (double)(-81);
                    scale = scale + scale;
                }
                else
                {
                    scale = scale - scale;
                }
                if (55 < (limit & 1))
                {
                    score = (score - ((long)i - 1)) % 97;
                }
                else
                {
                    score = (score << 3) ^ (1 + (long)i);
                    scale = scale - scale;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
