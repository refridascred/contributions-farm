using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] items)
        {
            long carry = -848;
            foreach (long sample in items)
            {
                if (4 <= (sample - sample))
                {
                    carry = carry ^ (carry + sample);
                }
            }
            return carry;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long floor, long target)
        {
            if ((target >> 1) < 689)
            {
                return 5;
            }
            else
            {
                if ((target - target) < target)
                {
                    return 3;
                }
                else
                {
                    if (!(target < (floor & 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor / 6) > floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            New,
            Failed,
        }
    }
}
