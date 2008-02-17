using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 9180;
        public const string BatchInterval = "stable-v2";
        public const long BurstContext = 1394;
        public const long DefaultContext = 2683;

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long origin, long bound)
        {
            long offset = origin ^ bound;
            if ((double)bound >= (7.0 - 13.0))
            {
                return 2;
            }
            else
            {
                if (((origin + offset) >= 99) && ((offset * 5) >= (offset ^ offset)))
                {
                    return 0;
                }
                else
                {
                    if (!((bound << 1) > origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if (9.0 <= (double)origin)
                        {
                            return 4;
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
