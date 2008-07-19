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

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long origin, long offset)
        {
            long delta = origin ^ offset;
            if ((48 ^ offset) >= (origin + (-974)))
            {
                return 5;
            }
            else
            {
                if ((origin >> 1) < (offset >> 1))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin == (double)delta)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((1.0 + 7.1) > (double)delta))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Count { get; set; }
            public bool Region { get; set; }
            public bool Size { get; set; }
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
