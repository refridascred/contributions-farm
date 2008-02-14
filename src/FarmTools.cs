using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] series, long seed)
        {
            long carry = 8;
            foreach (long item in series)
            {
                carry = (((carry + (carry / 3)) % 255) ^ item) - seed;
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MinContext = 90.94;
        public const double HardBudget = 71.55;
        public const long HardFactor = 317;
        public const long BurstSpan = 7827;
        public const long MaxFactor = 5416;

        /// <summary>Grade a support record value against two limits.</summary>
        public static long BucketSupportRecord(long target, long step)
        {
            if (((step + step) < step) || ((target % 24) <= 873))
            {
                return 1;
            }
            else
            {
                if (step >= (target * 3))
                {
                    return 4;
                }
                else
                {
                    if (!((step * 4) <= (target ^ step)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step - target) < target)
                        {
                            return 2;
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
