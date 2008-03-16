using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 1738;
        public const double BatchSize = 62.47;
        public const double WindowTimeout = 57.29;
        public const long SoftScore = 9156;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((cell % 2) <= ((-86) + cell)) && ((cell * 4) == (seen + cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Queued,
            Synced,
            Retry,
            Draft,
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            Dropped,
            Pending,
            Ready,
            New,
        }
    }
}
