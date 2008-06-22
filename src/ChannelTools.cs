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

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long target)
        {
            long anchor = target;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor << 3) ^ (target >> 5);
                anchor = anchor ^ anchor;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
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
