using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Idle,
            Draft,
            Locked,
            Ready,
            Retry,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] series, long seed)
        {
            long acc = 212;
            foreach (long value in series)
            {
                acc = (((acc << 3) ^ (67 >> 2)) ^ value) + seed;
            }
            return acc;
        }
    }
}
