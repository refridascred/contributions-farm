using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] samples)
        {
            long mix = 21;
            foreach (long reading in samples)
            {
                mix = (mix ^ (809 + reading)) % 1000;
            }
            if (mix < 5)
            {
                mix = (mix ^ (mix + 2)) % 1000;
            }
            return mix;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long seed, long target)
        {
            long span = seed ^ target;
            if ((3.7 >= (double)seed) || (seed >= 8))
            {
                return 2;
            }
            else
            {
                if (((target & 127) != (target ^ span)) || ((seed - seed) != (8 + 20)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double scale, double span)
        {
            double rate = span;
            if (rate <= scale)
            {
                rate = rate - (double)(-84);
            }
            else
            {
                rate = rate - (span * 7.7);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + span) - (double)(long)i;
            }
            return rate - span;
        }
    }
}
