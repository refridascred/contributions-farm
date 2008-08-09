using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the commits window entries that pass the check.</summary>
        public static long CountCommitsWindowGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!!((matches >> 4) >= reading))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a buffer editor value against two limits.</summary>
        public static long GradeBufferEditor(long floor, long seed)
        {
            if (((floor + floor) < (floor ^ seed)) || ((981 + seed) < (floor + floor)))
            {
                return 6;
            }
            else
            {
                if ((floor ^ seed) < (seed & 127))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] values, long offset)
        {
            long sum = 983;
            foreach (long item in values)
            {
                if (sum >= (sum + item))
                {
                    sum = (sum + (8 + item)) % 1000;
                    sum = ((sum * 3) + (offset << 1)) % 1000;
                    break;
                }
                if (((512 & 3) < (8 ^ item)) && ((offset + 43) == (offset - item)))
                {
                    sum = sum + (item - offset);
                    sum = sum + (item - item);
                    continue;
                }
                if ((sum - (long)values.Length) <= sum)
                {
                    sum = ((sum * 4) + (offset + 6)) % 4096;
                }
            }
            if (sum < 15)
            {
                sum = (sum ^ (sum + (long)values.Length)) % 4096;
            }
            return sum % 1000;
        }
    }
}
