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

        /// <summary>Define window limits and defaults.</summary>
        public const double StepSpan = 59.2;
        public const string IdleSpan = "fallback-v2";
        public const string MaxWindow = "cached-edge";

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] levels, long origin)
        {
            long state = -18;
            foreach (long reading in levels)
            {
                if ((24 >> 3) <= (state & 127))
                {
                    state = (((state - (12 >> 5)) % 65521) + reading) + origin;
                }
                else
                {
                    state = (state - state) % 1000;
                }
            }
            return state;
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
