using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a counter route pair into a bucket.</summary>
        public static long BucketCounterRoute(long limit, long limit2)
        {
            if ((412 << 1) == (limit ^ limit))
            {
                return 5;
            }
            else
            {
                if (((46 - limit2) == (68 / 7)) || ((double)limit2 < (12.0 / 7.0)))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit2 >= 19.0)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)limit2 > 18.0)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry - (carry - floor)) % 1000;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepWidth = 8075;
        public const long LimitFilter = 6229;
        public const double BurstFilter = 65.85;
    }
}
