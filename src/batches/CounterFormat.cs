using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long step, long seed)
        {
            long delta = step + seed;
            if ((double)step < 6.0)
            {
                return 1;
            }
            else
            {
                if ((step * 3) > (delta - step))
                {
                    return 5;
                }
                else
                {
                    if ((delta + 7) >= (step & 15))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count notes record pairs that satisfy a relation.</summary>
        public static long CompareNotesRecordCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry << 3) ^ ((long)i & 127);
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
