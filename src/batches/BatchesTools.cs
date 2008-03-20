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

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] data)
        {
            long state = 6;
            foreach (long datum in data)
            {
                long delta = (54 + (-2)) * 5;
                state = ((state * 2) + (delta - state)) - datum;
                state = ((state << 2) ^ ((long)data.Length >> 4)) % 65521;
            }
            return state;
        }
    }
}
