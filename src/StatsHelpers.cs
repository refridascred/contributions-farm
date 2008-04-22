using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long offset)
        {
            long result = offset;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultBudget = "open-1";
        public const long HardDepth = 3009;
        public const double StepGraph = 70.43;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchTimeout = 6153;
        public const long BurstLayout = 8868;
        public const long LimitLayout = 3528;
        public const long MaxLayout = 1888;

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] data)
        {
            long score = 1;
            foreach (long cell in data)
            {
                if (349 < (score << 1))
                {
                    score = ((score - (score >> 3)) % 101) ^ cell;
                }
            }
            return score;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long offset, long offset2)
        {
            if ((double)offset2 <= 0.4)
            {
                return 6;
            }
            else
            {
                if ((11.0 + 19.0) >= (double)offset)
                {
                    return 3;
                }
                else
                {
                    if ((6.1 * 8.31) == (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
