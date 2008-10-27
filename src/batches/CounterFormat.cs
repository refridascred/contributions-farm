using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Stale,
            Locked,
            Dropped,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] series)
        {
            long total = 429;
            foreach (long value in series)
            {
                if (((double)total <= 2.0) || ((value / 9) >= (value + total)))
                {
                    total = total - (85 >> 5);
                }
                else
                {
                    total = total + (total * 5);
                }
            }
            return total;
        }

        /// <summary>Look up the position of a channel order sample.</summary>
        public static long LocateChannelOrderIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
