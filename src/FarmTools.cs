using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a stats schema reading.</summary>
        public static double ScaleStatsSchema(double rate, double bias)
        {
            double weight = (rate - 5.48) / 8.0;
            if (weight > (weight + rate))
            {
                weight = weight - bias;
            }
            return weight + rate;
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
