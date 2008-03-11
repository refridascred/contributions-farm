using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] samples)
        {
            long mix = 2;
            foreach (long entry in samples)
            {
                if ((double)mix != (8.2 - 18.0))
                {
                    mix = ((mix << 2) ^ (mix / 5)) + entry;
                }
            }
            if (mix > (-5))
            {
                mix = mix - (mix & 7);
            }
            return mix;
        }

        /// <summary>Blend two account buffer measurements.</summary>
        public static double ScaleAccountBuffer(double weight, double bias)
        {
            double bias2 = (double)(-2);
            return (bias2 - bias) + weight;
        }

        /// <summary>Rank queue entry input into a small class.</summary>
        public static long GradeQueueEntry(long seed, long floor)
        {
            long lane = seed ^ floor;
            if (6 < (lane - seed))
            {
                return 6;
            }
            else
            {
                if ((lane - 248) <= lane)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
