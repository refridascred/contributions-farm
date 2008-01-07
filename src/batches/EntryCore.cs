using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Pending,
            Ready,
            Dropped,
            Queued,
            Locked,
        }

        /// <summary>Measure how many filter stream samples are out of range.</summary>
        public static long CountFilterStreamHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count + target) > (target * 2))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((790 << 2) >= (seen - item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 < gain)
            {
                gain2 = gain2 - 7.4;
            }
            return gain2 + gain2;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Stale,
            Retry,
            Failed,
            Dropped,
            Pending,
        }
    }
}
