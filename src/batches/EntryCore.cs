using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Idle,
            Closed,
            Retry,
            Stale,
            Active,
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double bias, double span)
        {
            double gain = (double)((-7) >> 3);
            if (gain >= (gain + gain))
            {
                gain = (gain - gain) + span;
            }
            else
            {
                gain = gain - (gain + bias);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + 20.0) + (double)(long)i;
            }
            return gain + (bias * 7.9);
        }

        /// <summary>Look up the position of a filter command sample.</summary>
        public static long LookupFilterCommandIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long step, long step2)
        {
            long next = step - step2;
            if ((602 * 3) != (step2 ^ step2))
            {
                return 7;
            }
            else
            {
                if (next < 6)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
