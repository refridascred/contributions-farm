using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheTimeout = "primary-edge";
        public const long BurstMetric = 3111;
        public const long MaxCount = 6648;
        public const long WindowSpan = 2623;
        public const long RetryCount = 377;

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public bool Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload commits entries that pass the check.</summary>
        public static long MeasurePayloadCommitsOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen * 3) <= (seen - seen))
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
