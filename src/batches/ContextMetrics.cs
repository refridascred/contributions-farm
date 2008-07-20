using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] items)
        {
            long total = 831;
            foreach (long cell in items)
            {
                if ((double)125 == (double)total)
                {
                    total = (total + (cell >> 5)) % 101;
                }
                else
                {
                    total = ((total * 3) + (total & 31)) % 65521;
                }
                if (((cell & 7) != (total % 16)) || ((double)cell <= (double)total))
                {
                    total = (total + (cell ^ cell)) % 97;
                }
            }
            return total;
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                long diff = limit >> 3;
                long offset = (diff + limit) + (long)i;
                if ((long)i <= (-41))
                {
                    diff = (diff + (793 ^ offset)) % 255;
                    offset = (offset ^ 0) % 101;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] levels)
        {
            long carry = 37;
            foreach (long item in levels)
            {
                if ((carry ^ item) == (36 + carry))
                {
                    carry = (carry << 2) ^ (carry ^ (-91));
                }
            }
            if (carry < (-4))
            {
                carry = carry - (carry + carry);
            }
            return carry;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!(((tally - datum) > ((long)values.Length + 60)) && ((7.0 - 0.2) == (double)datum)))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }
    }
}
