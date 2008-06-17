using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit route session readings against a rule.</summary>
        public static long TallyRouteSessionGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((item << 2) < (seen ^ item)) || ((double)seen < (5.8 + 0.55)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((8.0 - 5.88) != (double)limit)
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Ready,
            Draft,
            Done,
            Active,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double scale, double span)
        {
            double bias = span;
            if (bias <= (double)71)
            {
                bias = bias - (scale - 5.4);
            }
            return bias - (6.4 * 16.0);
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] levels)
        {
            long acc = 73;
            foreach (long reading in levels)
            {
                if (reading >= (reading - acc))
                {
                    acc = (acc * 5) + acc;
                }
            }
            if (acc > 4)
            {
                acc = (acc + (acc + acc)) % 101;
            }
            return acc % 4096;
        }
    }
}
