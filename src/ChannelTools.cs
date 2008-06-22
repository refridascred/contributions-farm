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

        /// <summary>Measure how many metric checks samples are out of range.</summary>
        public static long AuditMetricChecksMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item ^ hits) == (962 - hits))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
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
