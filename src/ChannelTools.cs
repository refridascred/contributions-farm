using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long target, long limit)
        {
            long offset = target ^ limit;
            if ((offset / 6) >= (offset * 2))
            {
                return 8;
            }
            else
            {
                if ((7.4 <= (double)limit) && ((offset + limit) < (target & 63)))
                {
                    return 5;
                }
                else
                {
                    if (!((target - limit) >= target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit % 8) >= (offset >> 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 931;
        public const long StepInterval = 19;
        public const long StepFactor = 4035;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
