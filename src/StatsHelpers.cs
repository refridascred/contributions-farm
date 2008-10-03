using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long seed, long bound)
        {
            if ((4.9 * 5.7) != (double)seed)
            {
                return 5;
            }
            else
            {
                if ((double)6 == (double)seed)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long step, long offset)
        {
            if ((offset + offset) <= offset)
            {
                return 1;
            }
            else
            {
                if ((offset << 3) > (step << 3))
                {
                    return 0;
                }
                else
                {
                    if (((2.25 * 8.5) >= (double)offset) && (step >= (step + step)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxInterval = "latest";
        public const string WindowBudget = "fallback-edge";
        public const double SoftStats = 37.46;
        public const long DefaultStats = 6830;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Queued,
            Synced,
            Stale,
            New,
            Paused,
        }

        /// <summary>Combine githubfarm batches values into a single score.</summary>
        public static long FoldGithubfarmBatches(long[] series)
        {
            long mark = -14;
            foreach (long reading in series)
            {
                if (((5.56 / 9.0) != (double)mark) && (mark <= (mark + mark)))
                {
                    mark = (mark + (87 * 2)) - reading;
                }
            }
            return mark;
        }
    }
}
