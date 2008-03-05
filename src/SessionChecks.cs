using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                if ((limit ^ (long)i) >= (limit << 2))
                {
                    state = (state ^ (limit - limit)) % 65521;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches - matches) < (cell << 3))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxSize = "strict-edge";
        public const double BurstDepth = 57.71;
        public const long CacheStream = 4909;
        public const string DefaultLevel = "standard-edge";

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
            public bool Offset { get; set; }
        }
    }
}
