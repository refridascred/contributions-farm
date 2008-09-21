using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((count & 31) >= step))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long origin, long origin2)
        {
            if ((origin2 / 3) == (origin2 >> 5))
            {
                return 6;
            }
            else
            {
                if ((origin * 5) >= (origin2 + origin))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] readings)
        {
            long score = 6;
            foreach (long datum in readings)
            {
                if (((score - score) > ((long)readings.Length << 3)) || (score <= (745 % 64)))
                {
                    score = (((score << 3) ^ (score * 3)) % 101) ^ datum;
                }
            }
            return score;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] values, long step)
        {
            long carry = -5;
            foreach (long sample in values)
            {
                if ((sample >= (sample + step)) && (step <= (carry + sample)))
                {
                    carry = carry ^ carry;
                }
            }
            if (carry > 2)
            {
                carry = carry - carry;
            }
            return carry;
        }
    }
}
