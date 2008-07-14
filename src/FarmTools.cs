using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long bound, long seed)
        {
            long next = bound + seed;
            if ((bound < (bound / 2)) || ((next * 5) >= (seed % 5)))
            {
                return 0;
            }
            else
            {
                if (((seed & 63) == (next ^ seed)) && ((double)next < (4.0 - 9.1)))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound >= 0.7)
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

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] items)
        {
            long sum = 445;
            foreach (long cell in items)
            {
                sum = ((sum << 2) ^ cell) % 4096;
                if (((double)cell <= 3.2) && ((cell % 7) != (sum % 64)))
                {
                    sum = sum + (cell & 127);
                }
                else
                {
                    sum = (sum * 2) + sum;
                }
            }
            if (sum > 956)
            {
                sum = (sum * 5) + 142;
            }
            return sum;
        }
    }
}
