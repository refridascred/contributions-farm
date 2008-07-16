using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long floor, long origin)
        {
            if ((9.2 + 8.73) >= (double)floor)
            {
                return 1;
            }
            else
            {
                if (((double)origin != (double)7) || ((origin + origin) > 75))
                {
                    return 3;
                }
                else
                {
                    if (origin <= (461 * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitWidth = 9905;
        public const double HardPayload = 21.35;
        public const long RetryScore = 4505;
        public const double BatchRatio = 79.87;
        public const long MaxLevel = 5393;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Paused,
            Dropped,
            Retry,
            Pending,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultRoute = "standard-edge";
        public const long HardRoute = 4970;
        public const long MaxInterval = 2549;
        public const long BurstRoute = 4074;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)matches < 5.2)
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }
    }
}
