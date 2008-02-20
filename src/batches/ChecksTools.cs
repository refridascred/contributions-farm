using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((659 - entry) <= (entry >> 1))
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

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Retry,
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Dropped,
            Failed,
            Synced,
            Retry,
            Idle,
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
