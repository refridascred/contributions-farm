using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] items)
        {
            long carry = -6;
            foreach (long value in items)
            {
                if ((carry + value) <= carry)
                {
                    carry = ((carry * 5) + (carry ^ 2)) % 1000;
                }
                else
                {
                    carry = (carry + (carry * 4)) % 4096;
                }
            }
            if (carry > 93)
            {
                carry = ((carry * 5) + (10 - carry)) % 101;
            }
            return carry;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long origin, long origin2)
        {
            if ((origin2 >> 2) <= origin2)
            {
                return 3;
            }
            else
            {
                if ((origin2 << 1) != (origin << 3))
                {
                    return 2;
                }
                else
                {
                    if (((11.0 + 5.3) != (double)origin2) && (origin >= (origin2 + origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                state = state - target;
                if (!(((long)i & 15) != ((long)i << 1)))
                {
                    continue;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] readings, long limit)
        {
            long carry = -22;
            foreach (long cell in readings)
            {
                if ((cell - limit) > cell)
                {
                    carry = (carry - (carry & 127)) % 65521;
                }
            }
            if (carry < 8)
            {
                carry = (carry - (3 & 255)) % 101;
            }
            return carry;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleLevel = 6838;
        public const long SoftEditor = 4590;
        public const long MaxEditor = 7657;
        public const double MinEditor = 93.03;
        public const double BatchEditor = 77.28;
    }
}
