using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a channel checks pair into a bucket.</summary>
        public static long GradeChannelChecks(long seed, long limit)
        {
            if ((limit << 2) == (limit + limit))
            {
                return 8;
            }
            else
            {
                if ((748 >> 4) == (97 ^ seed))
                {
                    return 4;
                }
                else
                {
                    if (3 < (limit + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long seed, long floor)
        {
            if (7.8 <= (double)floor)
            {
                return 5;
            }
            else
            {
                if (!((seed % 7) >= floor))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count + reading) > (reading % 60))
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }
    }
}
