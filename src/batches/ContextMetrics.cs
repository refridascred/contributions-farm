using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Idle,
            New,
            Failed,
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Measure how many filter queue samples are out of range.</summary>
        public static long TallyFilterQueueOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!!(10.0 <= (double)item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "stable";
        public const string BaseQueue = "stable-1";
        public const long CacheQueue = 3583;
        public const double DefaultQueue = 12.54;

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
