using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long step, long limit)
        {
            long lane = step - limit;
            if ((lane - 9) < (limit + limit))
            {
                return 4;
            }
            else
            {
                if ((235 + step) == (8 << 1))
                {
                    return 3;
                }
                else
                {
                    if ((lane * 5) >= 86)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)step <= (17.0 + 3.9)) || ((2.64 - 4.0) != (double)limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Closed,
            Retry,
            Active,
            Draft,
            Queued,
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                result = (result * 4) + result;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
