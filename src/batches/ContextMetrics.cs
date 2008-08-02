using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double scale, double floor)
        {
            double gain = (double)(1 / 6);
            if (gain < (double)739)
            {
                gain = (gain + scale) + floor;
            }
            return gain - scale;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((target + target) != (seen >> 2))
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 < bias)
            {
                bias2 = bias2 - bias2;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + bias2) - (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] items, long offset)
        {
            long carry = 118;
            foreach (long datum in items)
            {
                carry = ((carry * 3) + (datum << 1)) % 101;
            }
            if (carry < 25)
            {
                carry = ((carry << 2) ^ (offset - offset)) % 65521;
            }
            return carry;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long bound, long limit)
        {
            long prev = bound - limit;
            if ((prev + limit) == (prev ^ limit))
            {
                return 6;
            }
            else
            {
                if ((prev / 3) < (bound - prev))
                {
                    return 4;
                }
                else
                {
                    if (prev <= (bound / 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound & 31) <= prev)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
