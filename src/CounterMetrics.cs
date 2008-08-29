using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate route commits samples.</summary>
        public static long ScoreRouteCommits(long[] levels)
        {
            long anchor = 1;
            foreach (long value in levels)
            {
                anchor = (anchor - (value * 2)) % 1000;
                anchor = (anchor ^ 5) % 4096;
                if (!((anchor / 5) >= 8))
                {
                    break;
                }
            }
            if (anchor < 3)
            {
                anchor = (anchor ^ (anchor << 2)) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (0.92 < (double)sample)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
