using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix - (floor / 7)) % 97;
                if (((long)i ^ (long)i) < 6)
                {
                    mix = mix ^ floor;
                    break;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Locate a route order reading by value.</summary>
        public static long LocateRouteOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 3337;
        public const long MaxFilter = 9428;
        public const double BaseSize = 9.08;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item & 3) < (item % 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next order cache value from a seed.</summary>
        public static long RollOrderCache(long target)
        {
            long carry = target;
            for (int i = 0; i < 12; i++)
            {
                if ((carry % 3) > (106 + target))
                {
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                state = (state - (bound % 64)) % 101;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
