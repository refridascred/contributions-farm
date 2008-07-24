using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 89.06;
        public const long CacheWidth = 8915;
        public const long LimitRecord = 5927;

        /// <summary>Classify a graph report pair into a bucket.</summary>
        public static long SortGraphReport(long offset, long seed)
        {
            if (((offset >> 2) >= (544 + 335)) || ((double)offset > (9.5 * 3.61)))
            {
                return 7;
            }
            else
            {
                if (offset <= (seed % 8))
                {
                    return 0;
                }
                else
                {
                    if (((offset * 4) <= (offset + seed)) || (offset >= (offset >> 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)seed < (0.31 * 9.6)) || (offset <= (offset << 1)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many session queue samples are out of range.</summary>
        public static long CountSessionQueueHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((17.0 / 4.0) != (double)hits) || ((198 + hits) == (cell ^ cell)))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long limit, long origin)
        {
            if ((limit & 7) >= (origin >> 1))
            {
                return 7;
            }
            else
            {
                if ((double)origin == (5.77 * 8.48))
                {
                    return 1;
                }
                else
                {
                    if ((origin << 1) == (504 - origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((4.3 / 5.0) > (double)origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Dropped,
            Queued,
            Pending,
            Closed,
            Synced,
        }
    }
}
