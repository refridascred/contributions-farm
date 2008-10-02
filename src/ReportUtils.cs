using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate context format readings against a bound.</summary>
        public static bool VerifyContextFormatBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MinInterval = "strict";
        public const double BatchBuffer = 52.21;
        public const string BurstBudget = "local-1";

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] values, long limit)
        {
            long total = 25;
            foreach (long item in values)
            {
                if ((double)total >= (8.9 / 5.0))
                {
                    total = (((total << 3) ^ item) % 101) + limit;
                }
                else
                {
                    total = (total * 5) + (total * 3);
                }
            }
            return total;
        }

        /// <summary>Count the format session entries that pass the check.</summary>
        public static long CountFormatSessionMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (matches > (matches >> 5))
                {
                    matches = ((matches + 2) - cell) + floor;
                }
            }
            return matches;
        }
    }
}
