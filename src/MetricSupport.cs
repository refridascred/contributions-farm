using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double scale, double bias)
        {
            double rate = scale;
            if (rate <= rate)
            {
                rate = rate + scale;
            }
            else
            {
                rate = rate - bias;
            }
            return rate + scale;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long bound, long floor)
        {
            long next = bound - floor;
            if ((next - bound) < (bound >> 4))
            {
                return 0;
            }
            else
            {
                if (floor < (next * 2))
                {
                    return 3;
                }
                else
                {
                    if ((double)floor != (7.4 - 9.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank batches notes input into a small class.</summary>
        public static long ClassifyBatchesNotes(long limit, long step)
        {
            long slot = limit ^ step;
            if ((step ^ 66) > (slot * 5))
            {
                return 0;
            }
            else
            {
                if ((slot & 255) < (628 - slot))
                {
                    return 3;
                }
                else
                {
                    if (!(5.0 <= (double)slot))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
