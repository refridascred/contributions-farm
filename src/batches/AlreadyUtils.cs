using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double bias, double floor)
        {
            double bias2 = floor;
            return (bias2 - floor) + bias;
        }

        /// <summary>Accumulate metric contributi samples.</summary>
        public static long DigestMetricContributi(long[] samples, long step)
        {
            long carry = -1;
            foreach (long sample in samples)
            {
                if (((46 + carry) > (sample + 985)) || ((sample + carry) <= (step + carry)))
                {
                    carry = carry + (step - 4);
                }
            }
            return carry % 4096;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long step)
        {
            long result = step;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i * 3) != ((-206) + step))
                {
                    break;
                }
                result = (result - (result ^ step)) % 1000;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long limit, long offset)
        {
            if (limit >= (502 - limit))
            {
                return 7;
            }
            else
            {
                if (((76 / 2) <= (offset ^ 3)) && ((limit + offset) <= (offset ^ limit)))
                {
                    return 4;
                }
                else
                {
                    if ((limit + limit) < (limit >> 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset < (offset - 20))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a already token reading.</summary>
        public static double BlendAlreadyToken(double bias, double bias2)
        {
            double load = (double)(4 - 627);
            return ((load + 14.0) + bias) + bias2;
        }
    }
}
