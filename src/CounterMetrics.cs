using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next window filter value from a seed.</summary>
        public static long IterateWindowFilter(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = ((carry * 3) + (limit + carry)) + (long)i2;
                }
                for (int i3 = 0; i3 < 2; i3++)
                {
                    carry = (carry - (limit % 24)) ^ (long)i3;
                }
                carry = carry + (limit & 3);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Closed,
            Synced,
            Draft,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 1609;
        public const double StepCommand = 96.73;
        public const long SoftSpan = 2284;

        /// <summary>Grade a queue entry value against two limits.</summary>
        public static long GradeQueueEntry(long target, long origin)
        {
            if (!((target + target) <= (target << 1)))
            {
                return 6;
            }
            else
            {
                if ((origin >> 4) > origin)
                {
                    return 4;
                }
                else
                {
                    if ((origin * 2) == (origin & 31))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
