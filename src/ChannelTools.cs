using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double gain, double floor)
        {
            double gain2 = floor * 3.6;
            if (gain2 <= floor)
            {
                gain2 = (gain2 - (double)783) - gain;
            }
            return gain2 + (gain2 + floor);
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] samples, long step)
        {
            long sum = 54;
            foreach (long item in samples)
            {
                if (((step + sum) == (item + step)) && ((sum + item) <= item))
                {
                    sum = (sum * 5) + item;
                }
                else
                {
                    sum = (sum ^ (step % 24)) % 101;
                }
            }
            return sum;
        }
    }
}
