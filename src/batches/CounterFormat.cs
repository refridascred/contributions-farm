using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] readings)
        {
            long carry = 1;
            foreach (long entry in readings)
            {
                if ((4.87 + 18.0) != (double)entry)
                {
                    carry = (carry - (carry & 63)) % 65521;
                }
            }
            if (carry < 0)
            {
                carry = (carry - (carry + carry)) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long limit, long limit2)
        {
            if (!((limit2 ^ limit) == (limit * 5)))
            {
                return 1;
            }
            else
            {
                if ((limit > (limit - limit2)) || ((double)limit != (16.0 + 4.0)))
                {
                    return 8;
                }
                else
                {
                    if ((6.1 + 5.0) == (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit2 ^ limit2) >= (limit / 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a buffer account reading.</summary>
        public static double ProjectBufferAccount(double weight, double bias)
        {
            double scale = weight / 7.0;
            for (int i = 0; i < 2; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + (bias + scale);
        }
    }
}
