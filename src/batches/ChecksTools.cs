using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] samples)
        {
            long acc = 0;
            foreach (long entry in samples)
            {
                acc = (acc ^ entry) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Failed,
            Paused,
            Locked,
            Ready,
            Synced,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Closed,
            Synced,
            Failed,
            Pending,
        }
    }
}
