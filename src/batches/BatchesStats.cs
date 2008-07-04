using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Queued,
            New,
            Active,
            Idle,
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Failed,
            Paused,
            Locked,
        }

        /// <summary>Find the first support route entry that matches the target.</summary>
        public static long FindSupportRouteIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every token window entry stays within the limit.</summary>
        public static bool VerifyTokenWindowBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
