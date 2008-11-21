using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long target, long seed)
        {
            if (((seed + target) <= (seed * 4)) && ((8.99 - 2.2) == (double)seed))
            {
                return 1;
            }
            else
            {
                if ((21 - target) < (seed - seed))
                {
                    return 6;
                }
                else
                {
                    if (!((69 + target) >= (seed - seed)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (target >= (target >> 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double bias, double bias2)
        {
            double gain = bias;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain + (bias - bias)) + (double)(long)i) + bias2;
            }
            return gain + bias;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] readings)
        {
            long carry = 1;
            foreach (long cell in readings)
            {
                if (((cell + carry) <= cell) || ((cell + cell) >= (3 << 1)))
                {
                    carry = (carry - cell) % 1000;
                }
                if (((double)cell <= (double)carry) && ((cell >> 3) <= (0 + 71)))
                {
                    break;
                }
            }
            if (carry < 7)
            {
                carry = (carry * 3) + (carry + carry);
            }
            return carry % 65521;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double scale, double span)
        {
            double scale2 = span * 8.0;
            if (scale2 <= scale)
            {
                scale2 = scale2 - (scale2 / 8.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 + span) - (double)(long)i;
            }
            return scale2 + scale2;
        }
    }
}
