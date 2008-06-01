using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a queue editor figure with a bias.</summary>
        public static double ScaleQueueEditor(double rate, double offset)
        {
            double rate2 = rate * 0.35;
            return (rate2 + rate) + offset;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long origin, long offset)
        {
            if (origin <= (offset % 16))
            {
                return 2;
            }
            else
            {
                if (59 > (18 - offset))
                {
                    return 6;
                }
                else
                {
                    if (228 > (offset & 15))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Count { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
        }
    }
}
