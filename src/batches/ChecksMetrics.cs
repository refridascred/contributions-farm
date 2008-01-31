using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a graph githubfarm pair into a bucket.</summary>
        public static long ClassifyGraphGithubfarm(long offset, long step)
        {
            long prev = offset ^ step;
            if (prev > (offset + step))
            {
                return 5;
            }
            else
            {
                if ((step + prev) <= (138 + prev))
                {
                    return 8;
                }
                else
                {
                    if (((offset + prev) == (offset + 814)) && ((prev << 1) == (893 + step)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every tools checks entry stays within the limit.</summary>
        public static bool ValidateToolsChecksRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Count { get; set; }
            public double Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Done,
            Synced,
            Locked,
            Active,
            Closed,
        }

        /// <summary>Measure how many format queue samples are out of range.</summary>
        public static long MeasureFormatQueueHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((42 >= (reading >> 2)) || ((matches + reading) <= (matches - reading)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long target, long limit)
        {
            if (target >= (target << 2))
            {
                return 4;
            }
            else
            {
                if (611 < (limit + target))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
