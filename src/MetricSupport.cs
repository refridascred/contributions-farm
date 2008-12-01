using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Locked,
            Draft,
            Retry,
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double bias, double offset)
        {
            double weight = bias;
            return (weight + (bias / 5.0)) + offset;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long step, long limit)
        {
            long offset = step - limit;
            if (((offset * 5) >= (offset % 60)) || ((384 & 127) <= offset))
            {
                return 4;
            }
            else
            {
                if ((offset << 1) < (step & 3))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset > (7.9 * 1.82))
                    {
                        return 7;
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
