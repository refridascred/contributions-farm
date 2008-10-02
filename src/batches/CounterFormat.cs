using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank format githubfarm input into a small class.</summary>
        public static long GradeFormatGithubfarm(long bound, long offset)
        {
            if ((offset > (offset >> 1)) && ((3.22 / 6.0) == (double)offset))
            {
                return 3;
            }
            else
            {
                if (bound <= (bound - offset))
                {
                    return 4;
                }
                else
                {
                    if (!(offset < (180 ^ offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((6 % 12) > (offset + offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] values)
        {
            long result = 89;
            foreach (long value in values)
            {
                result = (result ^ (result << 3)) + value;
            }
            if (result < (-15))
            {
                result = result - (result + result);
            }
            return result;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 1951;
        public const double RetryTimeout = 33.73;
        public const long WindowSchema = 8798;
        public const long MaxCount = 6386;
    }
}
