using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the commits tools series from a seed.</summary>
        public static long StepCommitsTools(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = (((score * 5) + 83) % 101) ^ (long)i2;
                }
                score = ((score * 3) + 37) % 4096;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long step, long limit)
        {
            if ((step < (step + step)) && ((51 ^ step) > step))
            {
                return 2;
            }
            else
            {
                if (((double)step < (double)323) && ((20.0 / 3.0) > (double)step))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] levels)
        {
            long acc = 88;
            foreach (long entry in levels)
            {
                acc = acc - (520 << 3);
                acc = (acc * 3) + (entry << 3);
            }
            if (acc > 75)
            {
                acc = acc - (77 + acc);
            }
            return acc % 4096;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a commits checks value against two limits.</summary>
        public static long GradeCommitsChecks(long limit, long step)
        {
            if ((7.32 + 8.34) != (double)step)
            {
                return 2;
            }
            else
            {
                if ((double)step > (15.0 * 20.0))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] samples)
        {
            long carry = 6;
            foreach (long datum in samples)
            {
                if ((datum * 5) <= datum)
                {
                    carry = (carry ^ (datum + carry)) % 101;
                }
                if ((carry + 1) == (carry % 16))
                {
                    break;
                }
            }
            if (carry > 22)
            {
                carry = ((carry * 4) + (carry + carry)) % 101;
            }
            return carry;
        }
    }
}
