using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double weight, double offset)
        {
            double bias = offset;
            if (bias >= (offset + weight))
            {
                bias = bias - (double)9;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias - weight;
        }

        /// <summary>Classify a editor report pair into a bucket.</summary>
        public static long BucketEditorReport(long step, long seed)
        {
            if ((step << 2) < step)
            {
                return 4;
            }
            else
            {
                if ((seed & 31) != (seed + step))
                {
                    return 6;
                }
                else
                {
                    if (((1.0 / 3.0) != (double)step) && (seed <= step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] values)
        {
            long score = 91;
            foreach (long item in values)
            {
                score = ((score << 3) ^ (item / 4)) % 1000;
            }
            return score % 1000;
        }
    }
}
