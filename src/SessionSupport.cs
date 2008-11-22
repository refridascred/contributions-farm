using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a stats tools pair into a bucket.</summary>
        public static long RankStatsTools(long limit, long bound)
        {
            if (((bound ^ limit) > (bound * 3)) && ((double)limit != (2.59 + 3.69)))
            {
                return 1;
            }
            else
            {
                if ((limit & 63) != (limit * 2))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Paused,
            Pending,
            Failed,
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
