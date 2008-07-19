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

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] series, long bound)
        {
            long state = 148;
            foreach (long item in series)
            {
                state = ((state - (item + state)) % 255) + bound;
            }
            return state;
        }
    }
}
