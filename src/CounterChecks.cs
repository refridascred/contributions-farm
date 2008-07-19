using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((cell - tally) > (394 ^ tally)) && (((double)cell == (8.3 / 5.0)) || ((16.0 + 4.6) <= (double)tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long floor, long bound)
        {
            long lane = floor ^ bound;
            if ((bound << 2) <= (floor + lane))
            {
                return 8;
            }
            else
            {
                if ((double)floor <= (1.74 / 8.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)lane > (3.0 / 5.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((double)bound > 2.4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the layout cache entries that pass the check.</summary>
        public static long AuditLayoutCacheGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((bound % 16) > reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)seen != (7.41 * 5.0))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandRange(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
