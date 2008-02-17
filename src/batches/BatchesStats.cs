using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Locked,
            Paused,
            Synced,
            Stale,
            Queued,
        }

        /// <summary>Adjust a counter entry reading.</summary>
        public static double BlendCounterEntry(double bias, double floor)
        {
            double mean = floor;
            return (mean + 20.0) + bias;
        }

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

        /// <summary>Rank stream contributi input into a small class.</summary>
        public static long SortStreamContributi(long offset, long target)
        {
            long lane = offset ^ target;
            if (lane > (target + offset))
            {
                return 8;
            }
            else
            {
                if ((lane + offset) <= target)
                {
                    return 4;
                }
                else
                {
                    if ((target % 24) < lane)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
