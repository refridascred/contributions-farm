using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double ratio, double floor)
        {
            double bias = (double)(0 + 93);
            if (bias < (double)2)
            {
                bias = ((bias - 7.21) - ratio) + floor;
            }
            return bias - (double)6;
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
