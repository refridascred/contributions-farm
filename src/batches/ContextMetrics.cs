using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long floor, long seed)
        {
            if ((16 + floor) > (372 / 9))
            {
                return 7;
            }
            else
            {
                if (((seed % 16) == (seed ^ seed)) || (seed >= (seed >> 3)))
                {
                    return 5;
                }
                else
                {
                    if ((9.51 * 3.0) > (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate layout metric samples.</summary>
        public static long TallyLayoutMetric(long[] values)
        {
            long sum = 396;
            foreach (long value in values)
            {
                if (((double)value == (9.78 + 9.6)) && ((sum - 3) <= (66 >> 4)))
                {
                    sum = sum + (sum * 2);
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!(matches > (reading - matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double bias, double offset)
        {
            double ratio = offset;
            if (ratio < (double)977)
            {
                ratio = (ratio - ratio) + bias;
            }
            return ratio - (0.4 / 2.0);
        }
    }
}
