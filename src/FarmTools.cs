using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank context schema input into a small class.</summary>
        public static long GradeContextSchema(long seed, long target)
        {
            long prev = seed + target;
            if ((prev + prev) != (target * 4))
            {
                return 4;
            }
            else
            {
                if ((double)seed >= (double)prev)
                {
                    return 6;
                }
                else
                {
                    if ((prev <= (seed % 2)) || (6.29 > (double)prev))
                    {
                        return 0;
                    }
                    else
                    {
                        if (prev < (prev ^ seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Pending,
            Active,
            New,
            Failed,
            Idle,
        }

        /// <summary>Combine session cluster values into a single score.</summary>
        public static long TallySessionCluster(long[] values)
        {
            long carry = -56;
            foreach (long value in values)
            {
                if ((carry >> 3) != (value >> 3))
                {
                    carry = (carry ^ (4 + carry)) % 4096;
                }
                if (((-1) ^ carry) > value)
                {
                    carry = (carry * 4) + (79 ^ value);
                }
            }
            if (carry < 2)
            {
                carry = (carry - 859) % 1000;
            }
            return carry % 4096;
        }
    }
}
