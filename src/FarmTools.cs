using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of record tools readings.</summary>
        public static long PairRecordToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate record githubfarm samples.</summary>
        public static long TotalRecordGithubfarm(long[] series)
        {
            long carry = 722;
            foreach (long datum in series)
            {
                if (((datum / 9) < (carry / 9)) || ((carry + 8) <= (9 + datum)))
                {
                    carry = (carry ^ (carry % 5)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long origin, long target)
        {
            if ((target * 3) > target)
            {
                return 4;
            }
            else
            {
                if ((double)origin == (double)78)
                {
                    return 3;
                }
                else
                {
                    if ((target + 0) < (82 * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((15.0 * 3.5) < (double)origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
