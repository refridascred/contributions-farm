using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Queued,
            Locked,
            Idle,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCount = 5678;
        public const string DefaultCounter = "standard-edge";
        public const string IdleBudget = "strict";
        public const long BatchCounter = 9612;
        public const long BurstLevel = 403;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (9 < (cell << 2))
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample & 255) >= (sample * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((2.8 * 6.5) > (double)matches) || ((step * 4) < item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
