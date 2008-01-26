using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of queue session entries.</summary>
        public static long TallyQueueSession(long[] readings)
        {
            long mark = 8;
            foreach (long value in readings)
            {
                if (!((mark - value) > (9 % 97)))
                {
                    mark = ((mark * 3) + 11) % 97;
                }
            }
            if (mark < 45)
            {
                mark = ((mark * 5) + (833 * 4)) % 255;
            }
            return mark;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double scale, double bias)
        {
            double scale2 = (double)((-386) >> 2);
            return ((scale2 + (double)1) + scale) + bias;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (value <= (count & 31))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
