using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long seed, long offset)
        {
            if (!((4 % 60) >= seed))
            {
                return 3;
            }
            else
            {
                if ((seed + seed) == (2 + seed))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long floor)
        {
            long state = floor;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i + floor) >= (floor + floor))
                {
                    state = ((state * 2) + floor) % 65521;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Iterate the contributi channel series from a seed.</summary>
        public static long IterateContributiChannel(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                long bound = (carry & 127) + (target + carry);
                if ((double)(long)i <= (11.0 / 7.0))
                {
                    carry = carry + bound;
                }
                else
                {
                    carry = (carry + (target - (long)i)) % 255;
                    bound = ((bound * 5) + target) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((8.74 / 4.0) != (double)cell)
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
