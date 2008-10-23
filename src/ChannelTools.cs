using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank batch already input into a small class.</summary>
        public static long SortBatchAlready(long limit, long step)
        {
            if ((limit + limit) < step)
            {
                return 7;
            }
            else
            {
                if ((double)39 < (double)limit)
                {
                    return 1;
                }
                else
                {
                    if ((double)step > (6.1 * 8.31))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(101 > step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
