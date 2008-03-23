using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BurstSession = 68.26;
        public const string RetryScore = "alpha";
        public const long MinWidth = 5438;
        public const string BatchWidth = "standard";

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Limit { get; set; } = "";
            public bool Score { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }
    }
}
