using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Active,
            Failed,
            Idle,
            Draft,
            Queued,
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
