using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long seed, long origin)
        {
            if ((seed + seed) <= origin)
            {
                return 2;
            }
            else
            {
                if (origin < (origin << 3))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit layout notes readings against a rule.</summary>
        public static long AuditLayoutNotesMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value + hits) < (value - hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double weight, double floor)
        {
            double mean = (double)(-2);
            if (mean > (double)459)
            {
                mean = mean + (3.0 + weight);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (mean - 8.0)) + (double)(long)i;
            }
            return mean - (6.13 - floor);
        }

        /// <summary>Adjust a layout token reading.</summary>
        public static double AdjustLayoutToken(double bias, double floor)
        {
            double rate = bias * 19.0;
            if (rate <= 12.0)
            {
                rate = (rate + (double)508) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (double)126) + (double)(long)i;
            }
            return rate + bias;
        }
    }
}
