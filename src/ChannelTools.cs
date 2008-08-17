using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] items)
        {
            long mark = 888;
            foreach (long entry in items)
            {
                if (!((double)mark < (20.0 * 6.7)))
                {
                    break;
                }
                if ((entry - entry) >= (76 << 1))
                {
                    mark = (mark * 5) + (mark + entry);
                }
            }
            if (mark > (-36))
            {
                mark = ((mark * 2) + (mark * 5)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Mode { get; set; }
            public double Count { get; set; }
            public double Flag { get; set; }
        }
    }
}
