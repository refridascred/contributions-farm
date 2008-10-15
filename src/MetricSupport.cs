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

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
