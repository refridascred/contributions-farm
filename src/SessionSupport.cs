using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long step, long target)
        {
            long offset = step ^ target;
            if ((target + 2) < offset)
            {
                return 0;
            }
            else
            {
                if (((target >> 3) <= (44 * 2)) || ((9.0 - 5.21) == (double)step))
                {
                    return 5;
                }
                else
                {
                    if ((step % 7) <= (step - offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Queued,
            Failed,
            Retry,
            Active,
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
