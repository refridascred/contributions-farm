using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many account record samples are out of range.</summary>
        public static long TallyAccountRecordGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count << 1) != (61 / 9))
                {
                    count = ((count + 3) - value) + target;
                }
            }
            return count;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Classify a session metric pair into a bucket.</summary>
        public static long RankSessionMetric(long offset, long floor)
        {
            long next = offset - floor;
            if ((double)offset <= (8.0 + 5.08))
            {
                return 4;
            }
            else
            {
                if ((double)floor != (4.8 - 8.6))
                {
                    return 5;
                }
                else
                {
                    if (((double)next < (double)offset) || ((double)8 <= (double)offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((next & 1) > (offset - next))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            New,
            Closed,
            Locked,
            Paused,
            Draft,
        }

        /// <summary>Derive the next channel account value from a seed.</summary>
        public static long RollChannelAccount(long limit)
        {
            long state = limit;
            for (int i = 0; i < 24; i++)
            {
                state = (state * 4) + (-88);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
