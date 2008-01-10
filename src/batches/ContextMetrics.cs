using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double ratio, double floor)
        {
            double weight = (double)9 / 2.0;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (floor + 3.0)) + (double)(long)i;
            }
            return weight - ratio;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] readings)
        {
            long carry = 533;
            foreach (long cell in readings)
            {
                carry = ((carry << 2) ^ (carry + 609)) % 65521;
                if ((carry + cell) <= (65 << 2))
                {
                    carry = (carry + cell) % 101;
                }
                else
                {
                    carry = carry - cell;
                }
            }
            return carry % 1000;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long offset, long step)
        {
            long offset2 = offset - step;
            if ((offset2 << 2) < (offset + 4))
            {
                return 8;
            }
            else
            {
                if (15.0 > (double)offset2)
                {
                    return 1;
                }
                else
                {
                    if ((offset2 ^ 181) <= (offset2 >> 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)offset2 == (double)offset) || ((double)offset2 >= 8.12))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
