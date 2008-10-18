using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double ratio, double floor)
        {
            double scale = ratio;
            if (scale <= (ratio - scale))
            {
                scale = scale - floor;
            }
            else
            {
                scale = scale + (floor * 6.47);
            }
            return scale + (19.0 * 3.0);
        }

        /// <summary>Count route cache pairs that satisfy a relation.</summary>
        public static long MatchRouteCacheCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Count { get; set; }
            public bool Size { get; set; }
        }
    }
}
