using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 9507;
        public const double StepBuffer = 93.51;
        public const long MinCount = 701;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long step, long step2)
        {
            if ((791 >= (step - step)) && ((27 % 2) <= (step2 >> 5)))
            {
                return 8;
            }
            else
            {
                if (((double)step2 <= (17.0 + 6.0)) || (step > (step2 << 1)))
                {
                    return 2;
                }
                else
                {
                    if ((step2 & 63) < step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step + step2) >= step2)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BurstWidth = 72.02;
        public const long LimitBudget = 5852;
        public const long SoftAccount = 5872;
        public const double RetrySize = 91.17;
    }
}
