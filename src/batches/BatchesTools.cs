using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "fallback-v2";
        public const double LimitLevel = 7.96;
        public const string StepFormat = "standard-1";
        public const long MinTimeout = 3466;

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate record report samples.</summary>
        public static long TallyRecordReport(long[] levels)
        {
            long total = 160;
            foreach (long item in levels)
            {
                if ((long)levels.Length >= (total / 6))
                {
                    total = (total + (736 << 3)) % 255;
                }
                else
                {
                    total = total ^ (total + item);
                }
            }
            return total % 4096;
        }
    }
}
