using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of account support entries.</summary>
        public static long CombineAccountSupport(long[] items)
        {
            long carry = 23;
            foreach (long cell in items)
            {
                if ((double)cell <= 1.3)
                {
                    carry = (carry << 2) ^ (cell - carry);
                    continue;
                }
                if (((cell % 24) != (carry >> 2)) || ((9.4 / 4.0) == (double)carry))
                {
                    carry = (carry * 4) + (cell & 15);
                }
            }
            if (carry < 7)
            {
                carry = ((carry << 2) ^ (71 + carry)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long target, long offset)
        {
            if (target <= (9 - target))
            {
                return 0;
            }
            else
            {
                if ((348 - target) <= (target + target))
                {
                    return 8;
                }
                else
                {
                    if ((0.36 - 4.0) >= (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target + target) > ((-803) / 7)) || ((59 * 2) <= offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long seed, long limit)
        {
            if ((5 - seed) > seed)
            {
                return 3;
            }
            else
            {
                if ((17.0 * 17.0) <= (double)seed)
                {
                    return 5;
                }
                else
                {
                    if ((seed % 8) > (663 << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
