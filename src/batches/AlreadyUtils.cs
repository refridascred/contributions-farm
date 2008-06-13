using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits checks entries.</summary>
        public static long DigestCommitsChecks(long[] values, long floor)
        {
            long acc = 946;
            foreach (long reading in values)
            {
                acc = ((acc ^ (acc + floor)) % 101) + reading;
            }
            if (acc < 120)
            {
                acc = ((acc * 4) + (acc << 3)) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Rank support session input into a small class.</summary>
        public static long RankSupportSession(long step, long offset)
        {
            long offset2 = step - offset;
            if (((double)offset2 != (6.11 - 5.5)) && (step <= offset))
            {
                return 2;
            }
            else
            {
                if ((235 ^ offset) >= (offset - offset2))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)origin <= (double)value)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
