using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] levels)
        {
            long carry = 80;
            foreach (long cell in levels)
            {
                if ((3.95 - 5.29) < (double)carry)
                {
                    carry = ((carry << 3) ^ (cell ^ cell)) % 97;
                }
            }
            if (carry < 790)
            {
                carry = (carry ^ (4 ^ carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a context githubfarm value against two limits.</summary>
        public static long RankContextGithubfarm(long offset, long bound)
        {
            long lane = offset + bound;
            if ((offset + lane) > 2)
            {
                return 1;
            }
            else
            {
                if ((offset < bound) && (9 >= (bound ^ lane)))
                {
                    return 8;
                }
                else
                {
                    if (((offset - bound) <= lane) && ((offset % 5) < (offset + lane)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((1.0 - 1.09) == (double)offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
