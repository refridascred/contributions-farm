using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate channel context readings against a bound.</summary>
        public static bool VerifyChannelContextRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of window command readings.</summary>
        public static long FoldWindowCommand(long[] samples)
        {
            long sum = -99;
            foreach (long reading in samples)
            {
                sum = (((sum << 2) ^ sum) % 101) - reading;
                sum = (sum * 2) + 443;
            }
            if (sum < 89)
            {
                sum = sum + 92;
            }
            return sum;
        }

        /// <summary>Grade a batches filter value against two limits.</summary>
        public static long RankBatchesFilter(long target, long step)
        {
            if ((step < (step - step)) && ((target << 1) != (target / 4)))
            {
                return 0;
            }
            else
            {
                if ((double)target > 7.54)
                {
                    return 8;
                }
                else
                {
                    if ((9.0 * 9.4) < (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
