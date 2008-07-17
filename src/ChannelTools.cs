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

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long offset, long bound)
        {
            long offset2 = offset ^ bound;
            if (!((offset & 3) != (offset - offset2)))
            {
                return 3;
            }
            else
            {
                if ((offset2 * 5) <= (bound - bound))
                {
                    return 2;
                }
                else
                {
                    if (offset2 > bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound * 2) < offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
