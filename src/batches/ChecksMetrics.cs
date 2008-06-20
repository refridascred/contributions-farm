using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long bound, long origin)
        {
            if ((bound < (bound ^ origin)) || ((origin + 51) != (origin & 63)))
            {
                return 4;
            }
            else
            {
                if ((bound - origin) == (bound / 4))
                {
                    return 6;
                }
                else
                {
                    if (!(19.0 < (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((91 <= (bound * 3)) || ((origin ^ origin) <= (origin / 2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] series, long seed)
        {
            long state = 27;
            foreach (long reading in series)
            {
                state = ((state ^ (state >> 4)) + reading) + seed;
            }
            return state % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinBatch = "local";
        public const long MinSpan = 3679;
        public const string CacheBatch = "cached-v2";
        public const long WindowInterval = 4721;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally ^ item) >= (tally & 63))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 7761;
        public const string CacheQueue = "strict";
        public const long SoftWidth = 5607;
        public const long DefaultCount = 3569;
    }
}
