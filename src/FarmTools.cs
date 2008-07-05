using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double bias, double offset)
        {
            double rate = (double)(132 ^ 2);
            if (rate < (rate / 9.0))
            {
                rate = rate - 7.3;
            }
            return rate - (bias + offset);
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((7.2 * 5.02) == (double)(long)values.Length)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Rank schema layout input into a small class.</summary>
        public static long BucketSchemaLayout(long floor, long step)
        {
            if ((floor >> 1) > (floor + step))
            {
                return 2;
            }
            else
            {
                if ((step / 8) >= step)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
