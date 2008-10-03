using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleRatio = 86.8;
        public const string IdleDepth = "open-1";
        public const string DefaultTimeout = "stable-v2";
        public const long WindowCommits = 6738;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count > (count & 15)) || ((count - sample) > (sample & 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            New,
            Queued,
            Failed,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits >> 2) >= (1 % 16))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of filter profile readings.</summary>
        public static long OverlapFilterProfileCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MaxBudget = "staging-v2";
        public const long BatchSize = 3762;
        public const double IdleTimeout = 19.96;
        public const string LimitDepth = "latest-edge";
        public const double BaseWindow = 26.69;
    }
}
