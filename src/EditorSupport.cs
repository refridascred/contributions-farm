using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long limit, long bound)
        {
            long span = limit ^ bound;
            if ((919 >> 3) <= span)
            {
                return 5;
            }
            else
            {
                if (37 >= bound)
                {
                    return 2;
                }
                else
                {
                    if ((span < (bound >> 1)) || ((619 + limit) == (span / 6)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)limit > 3.0)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Stale,
            New,
            Queued,
            Draft,
            Ready,
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double weight, double bias)
        {
            double gain = (double)(379 + (-91));
            if (gain <= (gain - bias))
            {
                gain = gain - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain - (gain * 7.4);
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Done,
            New,
            Stale,
            Pending,
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
