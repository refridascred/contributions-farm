using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Locked,
            Stale,
            Draft,
            Idle,
            New,
        }

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

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long step, long limit)
        {
            if (((limit % 64) == (13 << 2)) || (76 < (limit + 76)))
            {
                return 6;
            }
            else
            {
                if (((0.7 / 9.0) >= (double)step) || ((step - step) <= (98 % 10)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
