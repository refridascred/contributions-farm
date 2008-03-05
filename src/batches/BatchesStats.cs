using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string CacheFactor = "alpha";
        public const string BatchInterval = "strict-edge";
        public const long WindowToken = 9408;
        public const string MinToken = "alpha-edge";

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Stale,
            Draft,
            Active,
            Idle,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Idle,
            Synced,
            Failed,
            Queued,
            Pending,
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
