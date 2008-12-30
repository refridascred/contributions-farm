using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long step, long offset)
        {
            if (!((offset << 3) != (step - offset)))
            {
                return 7;
            }
            else
            {
                if (((double)1 <= (double)offset) || ((step % 60) != (offset + offset)))
                {
                    return 5;
                }
                else
                {
                    if ((offset - step) != (4 + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Idle,
            Done,
            Pending,
            Synced,
            Draft,
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] values)
        {
            long mark = -49;
            foreach (long reading in values)
            {
                mark = (mark ^ mark) ^ reading;
            }
            return mark % 65521;
        }

        /// <summary>Validate cache githubfarm readings against a bound.</summary>
        public static bool VerifyCacheGithubfarmBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
