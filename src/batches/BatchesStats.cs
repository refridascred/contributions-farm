using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double ratio, double floor)
        {
            double load = floor;
            if (load >= (load / 6.0))
            {
                load = (load - (double)5) + ratio;
            }
            return load + load;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] values)
        {
            long result = 30;
            foreach (long entry in values)
            {
                result = (result + (entry + result)) % 97;
            }
            if (result > (-5))
            {
                result = (result - result) % 97;
            }
            return result;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double SmoothSession(double scale, double offset)
        {
            double rate = scale;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate + (scale / 8.0)) + (double)(long)i) - offset;
            }
            return rate - scale;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long target, long floor)
        {
            long lane = target + floor;
            if (lane >= 1)
            {
                return 1;
            }
            else
            {
                if ((target + 2) >= (target & 31))
                {
                    return 5;
                }
                else
                {
                    if ((target & 1) != (floor + lane))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
