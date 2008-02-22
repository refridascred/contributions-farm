using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate stats account readings against a bound.</summary>
        public static bool GuardStatsAccountBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            New,
            Active,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] levels, long offset)
        {
            long mix = 2;
            foreach (long entry in levels)
            {
                if (entry >= (offset - entry))
                {
                    mix = (mix << 2) ^ 8;
                }
            }
            return mix % 1000;
        }
    }
}
