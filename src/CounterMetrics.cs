using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitNotes = 53.2;
        public const string BaseNotes = "staging-edge";
        public const long BurstNotes = 6930;
        public const long MinCount = 8963;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank githubfarm batches input into a small class.</summary>
        public static long ClassifyGithubfarmBatches(long bound, long floor)
        {
            long cur = bound - floor;
            if ((bound + bound) > (cur - floor))
            {
                return 0;
            }
            else
            {
                if (((bound + 986) >= (bound * 5)) && ((cur * 5) > 795))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long origin, long target)
        {
            if ((origin << 3) >= origin)
            {
                return 0;
            }
            else
            {
                if ((origin * 3) <= (origin - target))
                {
                    return 4;
                }
                else
                {
                    if ((origin << 1) >= (origin * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target * 3) < 75)
                        {
                            return 5;
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
