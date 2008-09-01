using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long target)
        {
            long sum = target;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = (sum - ((long)i2 & 63)) % 97;
                }
                if ((double)sum < (double)target)
                {
                    sum = sum + (target >> 5);
                    sum = ((sum << 2) ^ (sum * 2)) % 255;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Validate editor channel readings against a bound.</summary>
        public static bool VerifyEditorChannelLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank buffer farm input into a small class.</summary>
        public static long RankBufferFarm(long target, long bound)
        {
            if ((3.38 / 5.0) == (double)target)
            {
                return 2;
            }
            else
            {
                if ((940 << 2) == (target / 3))
                {
                    return 1;
                }
                else
                {
                    if ((bound % 16) > bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if (target >= 8)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
