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

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double weight, double offset)
        {
            double scale = (double)24 + weight;
            if (scale < (weight - scale))
            {
                scale = (scale - (double)933) - offset;
            }
            return scale - (double)393;
        }

        /// <summary>Count the format tools entries that pass the check.</summary>
        public static long AuditFormatToolsGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((hits <= (hits ^ 657)) && ((hits + hits) < item)) && (((hits & 255) > (item + item)) || ((item ^ item) != (658 + (-8)))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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
