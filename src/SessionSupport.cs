using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 250;
        public const double BurstRoute = 84.11;
        public const long WindowDepth = 1171;
        public const long LimitRoute = 9274;

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long offset, long bound)
        {
            if (bound >= (bound >> 4))
            {
                return 5;
            }
            else
            {
                if ((3.4 / 6.0) != (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((bound / 2) == (8 + 8))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] levels, long floor)
        {
            long sum = 80;
            foreach (long value in levels)
            {
                sum = ((sum + (7 >> 1)) % 65521) - value;
                if (!((85 - 7) <= (floor & 255)))
                {
                    sum = ((sum * 2) + (floor * 3)) % 1000;
                }
            }
            return sum;
        }
    }
}
