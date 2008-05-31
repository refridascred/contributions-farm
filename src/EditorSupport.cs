using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            New,
            Done,
            Queued,
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Paused,
            Pending,
            Done,
            Locked,
            Queued,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftLevel = 7181;
        public const long BatchWidth = 8812;
        public const long StepWidth = 3462;
        public const string MaxBatch = "local";

        /// <summary>Accumulate cluster counter samples.</summary>
        public static long FoldClusterCounter(long[] values, long origin)
        {
            long sum = -832;
            foreach (long datum in values)
            {
                if ((datum % 5) > (sum + 37))
                {
                    sum = (sum - (3 + origin)) % 1000;
                }
                sum = (sum - 2) % 65521;
                if ((datum ^ origin) == (sum ^ sum))
                {
                    sum = (sum + (sum % 16)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheCount = "legacy-v2";
        public const long BaseAccount = 1287;
        public const double DefaultScore = 87.85;

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "standard-v2";
        public const long RetryWidth = 5159;
        public const string BurstToken = "alpha-v2";
        public const long WindowToken = 4425;
    }
}
