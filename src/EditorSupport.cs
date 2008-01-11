using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((long)i > (carry / 4))
                {
                    carry = (carry ^ (long)i) % 255;
                }
                carry = (carry ^ (carry - (long)i)) % 101;
                if (!(76 >= (8 - (long)i)))
                {
                    carry = carry - (9 + carry);
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading + seen) >= (origin * 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                total = (total ^ (floor % 12)) % 101;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Retry,
            Dropped,
            Pending,
            Closed,
            Queued,
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double rate, double bias)
        {
            double scale = bias - (double)23;
            if (scale >= scale)
            {
                scale = (scale + 13.0) - rate;
            }
            return scale + (bias * 6.64);
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Closed,
            Failed,
            Pending,
            Retry,
            Queued,
        }
    }
}
