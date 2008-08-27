using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double ratio, double span)
        {
            double bias = span / 6.0;
            if (bias > (span / 5.0))
            {
                bias = bias - (bias + ratio);
            }
            return bias - (double)2;
        }

        /// <summary>Derive the next batch farm value from a seed.</summary>
        public static long StepBatchFarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long target, long target2)
        {
            if ((target2 * 4) <= 51)
            {
                return 6;
            }
            else
            {
                if (target < target2)
                {
                    return 7;
                }
                else
                {
                    if (((653 ^ target) >= (target << 1)) || ((7 & 1) >= (target + target)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((target / 5) < target2) || ((double)target >= (double)target2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
