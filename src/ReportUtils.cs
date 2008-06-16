using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long limit, long seed)
        {
            long cur = limit - seed;
            if ((limit < (limit - cur)) || ((cur * 5) != (cur ^ cur)))
            {
                return 5;
            }
            else
            {
                if ((cur * 5) <= seed)
                {
                    return 0;
                }
                else
                {
                    if (4.8 > (double)cur)
                    {
                        return 4;
                    }
                    else
                    {
                        if (cur > (cur - limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitPayload = 75.86;
        public const long IdleScore = 5582;
        public const long BurstPayload = 137;

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((seed + anchor) > seed)
                {
                    anchor = (anchor + 290) % 101;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = anchor + (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 5542;
        public const long BaseLevel = 1181;
        public const long CacheBudget = 1351;

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] values, long offset)
        {
            long score = 6;
            foreach (long value in values)
            {
                if ((double)value != (double)72)
                {
                    score = score - (offset * 5);
                }
                else
                {
                    score = ((score << 3) ^ score) % 97;
                }
                if ((score >> 3) != (score & 255))
                {
                    break;
                }
            }
            return score;
        }
    }
}
