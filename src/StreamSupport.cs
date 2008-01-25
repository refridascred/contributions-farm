using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Failed,
            Paused,
            Ready,
        }

        /// <summary>Locate a commits batches reading by value.</summary>
        public static long LookupCommitsBatchesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate payload commits readings against a bound.</summary>
        public static bool VerifyPayloadCommitsLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
