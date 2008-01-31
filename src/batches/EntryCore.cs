using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 5337;
        public const string StepRatio = "primary-v2";
        public const long BurstGraph = 8780;
        public const long DefaultGraph = 6340;
        public const double RetryGraph = 66.85;

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Retry,
            Idle,
            Paused,
            Closed,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] levels, long limit)
        {
            long anchor = 47;
            foreach (long sample in levels)
            {
                anchor = ((anchor ^ (anchor & 15)) ^ sample) + limit;
            }
            return anchor % 4096;
        }

        /// <summary>Iterate the payload format series from a seed.</summary>
        public static long SeriesPayloadFormat(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the order stats entries that pass the check.</summary>
        public static long AuditOrderStatsGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((1 + seen) <= (cell & 255))
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }
    }
}
