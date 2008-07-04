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

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long step)
        {
            long mix = step;
            for (int i = 0; i < 23; i++)
            {
                mix = mix + step;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
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
