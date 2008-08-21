using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long target, long target2)
        {
            if (!((target2 - 514) != (target2 / 2)))
            {
                return 8;
            }
            else
            {
                if ((target - 8) >= (target - 388))
                {
                    return 2;
                }
                else
                {
                    if (!((target >> 4) > (target2 * 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (target > (target2 / 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of stream queue entries.</summary>
        public static long WeighStreamQueue(long[] values)
        {
            long carry = 540;
            foreach (long cell in values)
            {
                if ((double)cell > (8.0 + 2.75))
                {
                    carry = (carry - (1 + carry)) % 97;
                }
                if ((carry - cell) != (carry % 12))
                {
                    break;
                }
            }
            if (carry < 65)
            {
                carry = (carry + carry) % 97;
            }
            return carry % 97;
        }
    }
}
