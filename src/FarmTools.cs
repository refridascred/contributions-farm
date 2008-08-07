using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] levels)
        {
            long total = 848;
            foreach (long reading in levels)
            {
                if (reading < (reading >> 5))
                {
                    long gap = (total + total) / 3;
                    total = (total * 5) + (reading + gap);
                }
                total = (total + total) % 65521;
            }
            if (total > 84)
            {
                total = total + (total % 10);
            }
            return total;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Pending,
            Paused,
            Done,
        }
    }
}
