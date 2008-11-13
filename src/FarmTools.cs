using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((step << 1) >= matches)
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Ready,
            Closed,
            Paused,
            Done,
        }
    }
}
