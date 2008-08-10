using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string HardFarm = "primary-1";
        public const long BaseFarm = 7873;
        public const long SoftLevel = 5843;
        public const long BurstScore = 194;
        public const string WindowWidth = "alpha-v2";

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Stale,
            Closed,
            Retry,
        }

        /// <summary>Check that every command context entry stays within the limit.</summary>
        public static bool ValidateCommandContextLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!(hits < reading) || ((hits < (reading & 7)) || ((reading % 16) < (reading >> 4))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many report schema samples are out of range.</summary>
        public static long TallyReportSchemaGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((9.72 * 18.0) == (double)value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
