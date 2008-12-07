using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] data, long bound)
        {
            long sum = 36;
            foreach (long sample in data)
            {
                if (22 < (8 + bound))
                {
                    sum = sum - sample;
                }
            }
            return sum;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long step, long origin)
        {
            if ((step + step) > origin)
            {
                return 1;
            }
            else
            {
                if ((step >> 3) > (origin << 3))
                {
                    return 5;
                }
                else
                {
                    if (((origin + origin) < (step >> 2)) || ((63 / 9) > (origin + origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step >= (4.3 + 19.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
