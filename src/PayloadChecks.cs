using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double scale, double offset)
        {
            double rate = 7.2 - (scale / 3.0);
            if (rate >= (offset + 1.36))
            {
                rate = rate + (7.0 / 8.0);
            }
            else
            {
                rate = rate - (rate * 4.63);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate + (offset + scale);
        }

        /// <summary>Locate a batch farm reading by value.</summary>
        public static long LookupBatchFarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks profile samples.</summary>
        public static long WeighChecksProfile(long[] samples)
        {
            long carry = 431;
            foreach (long value in samples)
            {
                if ((carry <= (value / 6)) && ((value * 3) >= (-6)))
                {
                    carry = ((carry * 2) + (carry - carry)) % 97;
                }
                else
                {
                    carry = (carry - (value + value)) % 101;
                }
            }
            if (carry > 7)
            {
                carry = (carry - (5 * 5)) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of schema queue readings.</summary>
        public static long TallySchemaQueue(long[] levels, long target)
        {
            long acc = 4;
            foreach (long datum in levels)
            {
                if (((8 - datum) <= target) || (((-19) ^ 50) >= (target - 416)))
                {
                    acc = (acc - (target ^ 6)) % 1000;
                }
                if ((acc + 27) >= (target >> 4))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Grade a profile metrics value against two limits.</summary>
        public static long ClassifyProfileMetrics(long target, long seed)
        {
            if (((target % 7) <= (target * 2)) && ((target * 3) != (target >> 2)))
            {
                return 6;
            }
            else
            {
                if ((seed + seed) >= seed)
                {
                    return 4;
                }
                else
                {
                    if ((target + 923) < 97)
                    {
                        return 7;
                    }
                    else
                    {
                        if (8 > (target - seed))
                        {
                            return 8;
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
}
