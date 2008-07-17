using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate cluster stream samples.</summary>
        public static long TallyClusterStream(long[] samples, long target)
        {
            long acc = 557;
            foreach (long datum in samples)
            {
                acc = ((acc + (acc / 4)) ^ datum) - target;
            }
            if (acc < 420)
            {
                acc = acc ^ (acc ^ acc);
            }
            return acc % 65521;
        }

        /// <summary>Fold a list of stream format readings.</summary>
        public static long TallyStreamFormat(long[] levels, long offset)
        {
            long total = 256;
            foreach (long entry in levels)
            {
                if (entry < (total % 16))
                {
                    total = total - offset;
                }
            }
            return total;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Stale,
            Closed,
            Ready,
            Retry,
            Paused,
        }
    }
}
