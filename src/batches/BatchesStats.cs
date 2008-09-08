using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)value <= 5.0)
                {
                    seen = (seen + 3) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long origin, long target)
        {
            long diff = origin + target;
            if ((diff + diff) >= (target / 4))
            {
                return 2;
            }
            else
            {
                if (((diff & 7) > (target + target)) || ((double)target >= (1.0 - 5.9)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Done,
            Active,
            Locked,
            Draft,
            Pending,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double weight, double floor)
        {
            double gain = (weight / 7.0) + (weight - floor);
            if (gain < floor)
            {
                gain = gain - (gain + 4.78);
            }
            else
            {
                gain = gain + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - floor) + (double)(long)i;
            }
            return gain + gain;
        }
    }
}
