using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a filter farm value against two limits.</summary>
        public static long BucketFilterFarm(long step, long seed)
        {
            if ((step & 31) > (seed + step))
            {
                return 2;
            }
            else
            {
                if (!((double)seed != (8.0 + 9.0)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long origin, long floor)
        {
            if (((floor / 6) != (349 & 15)) || ((4.0 + 4.01) == (double)floor))
            {
                return 4;
            }
            else
            {
                if ((0 + origin) == (origin << 2))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] readings, long offset)
        {
            long sum = 4;
            foreach (long value in readings)
            {
                sum = ((sum - (38 % 12)) + value) - offset;
            }
            return sum;
        }
    }
}
