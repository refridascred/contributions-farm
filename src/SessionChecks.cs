using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry >> 2) <= (step / 6))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Roll a commits account counter forward.</summary>
        public static long RollCommitsAccount(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 15; i++)
            {
                long next = seed / 2;
                if (((-3) * 2) == ((long)i - next))
                {
                    mark = (mark * 3) + 232;
                }
                else
                {
                    next = next + (next + next);
                    mark = (mark - (seed << 3)) % 255;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Ratio { get; set; }
            public long Total { get; set; }
        }
    }
}
