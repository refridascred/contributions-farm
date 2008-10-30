using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank commits token input into a small class.</summary>
        public static long RankCommitsToken(long floor, long origin)
        {
            if (floor > (floor + 24))
            {
                return 2;
            }
            else
            {
                if (floor < (32 * 4))
                {
                    return 7;
                }
                else
                {
                    if (floor >= (origin + origin))
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

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                if (mark >= (step * 3))
                {
                    mark = (mark - (45 % 10)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
