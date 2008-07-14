using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first order graph entry that matches the target.</summary>
        public static long LocateOrderGraphIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long seed, long floor)
        {
            long next = seed - floor;
            if ((0.83 * 7.7) > (double)next)
            {
                return 7;
            }
            else
            {
                if ((floor - next) < seed)
                {
                    return 5;
                }
                else
                {
                    if ((seed + floor) == (next & 1))
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

        /// <summary>Roll a already filter counter forward.</summary>
        public static long IterateAlreadyFilter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Label { get; set; }
            public long Mode { get; set; }
        }
    }
}
