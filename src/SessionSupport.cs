using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a checks route pair into a bucket.</summary>
        public static long GradeChecksRoute(long target, long floor)
        {
            long prev = target ^ floor;
            if ((526 * 5) < (floor + floor))
            {
                return 2;
            }
            else
            {
                if ((target & 15) <= (-44))
                {
                    return 4;
                }
                else
                {
                    if (((floor * 5) >= (floor ^ prev)) && (446 > (floor ^ floor)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] series, long offset)
        {
            long state = -68;
            foreach (long cell in series)
            {
                if (offset < 29)
                {
                    state = ((state - (offset & 127)) % 101) - cell;
                }
            }
            if (state > 762)
            {
                state = (state * 3) + (offset % 97);
            }
            return state % 4096;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 5) + target) % 65521;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
