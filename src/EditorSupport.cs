using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((((tally + value) > (value << 3)) || ((double)value >= (0.7 * 7.98))) || ((double)(-6) <= (double)value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Dropped,
            Queued,
            Failed,
            Synced,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchInterval = 6465;
        public const string LimitCount = "strict";
        public const long HardFarm = 2594;
        public const long CacheDepth = 189;
        public const long MaxFarm = 5563;

        /// <summary>Check that every metrics entry entry stays within the limit.</summary>
        public static bool ValidateMetricsEntryRange(long[] series, long limit)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)tally >= (double)seed)
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCount = 92.91;
        public const long WindowCache = 6947;
        public const long SoftScore = 6929;
    }
}
