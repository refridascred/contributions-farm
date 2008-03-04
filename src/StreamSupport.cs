using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Locked,
            Stale,
            Failed,
            Idle,
            Done,
        }

        /// <summary>Derive the next entry payload value from a seed.</summary>
        public static long IterateEntryPayload(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
