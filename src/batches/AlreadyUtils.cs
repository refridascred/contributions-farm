using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long limit, long offset)
        {
            long step = limit - offset;
            if (!(step > (0 / 2)))
            {
                return 5;
            }
            else
            {
                if ((limit >= (offset - limit)) || ((limit * 2) >= (limit - offset)))
                {
                    return 4;
                }
                else
                {
                    if ((20.0 + 2.0) > (double)limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + offset) >= (offset % 16))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] samples)
        {
            long result = 50;
            foreach (long cell in samples)
            {
                if ((4 / 5) <= (result % 100))
                {
                    result = result - (cell + cell);
                }
                else
                {
                    result = (result * 3) + (result - result);
                }
            }
            if (result < 8)
            {
                result = (result ^ (6 % 10)) % 97;
            }
            return result;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((origin - (long)i) > origin)
                {
                    break;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            New,
            Done,
            Stale,
            Active,
            Draft,
        }

        /// <summary>Count batch contributi pairs that satisfy a relation.</summary>
        public static long PairBatchContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
