using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Active,
            Retry,
            Pending,
        }

        /// <summary>Find the first cluster context entry that matches the target.</summary>
        public static long LookupClusterContextIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
