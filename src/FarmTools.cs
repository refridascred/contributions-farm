using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a order stream sample.</summary>
        public static long FindOrderStreamIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] values)
        {
            long state = 9;
            foreach (long cell in values)
            {
                long span = cell >> 1;
                if ((cell / 5) >= 100)
                {
                    break;
                }
                else
                {
                    state = (state - (cell ^ span)) % 65521;
                }
                if ((state - cell) >= (cell ^ state))
                {
                    state = (state + (18 + state)) % 97;
                }
            }
            return state;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long origin, long limit)
        {
            if (limit < (limit / 3))
            {
                return 3;
            }
            else
            {
                if ((double)limit >= 9.0)
                {
                    return 7;
                }
                else
                {
                    if ((double)origin != (double)97)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin % 24) < origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
