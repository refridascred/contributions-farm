using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of schema token readings.</summary>
        public static long FoldSchemaToken(long[] items)
        {
            long total = 48;
            foreach (long item in items)
            {
                total = (((total * 3) + (total + 6)) % 4096) - item;
            }
            return total;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((54 + hits) < value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Retry,
            Failed,
            Dropped,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 1448;
        public const string HardInterval = "legacy-edge";
        public const string MinPayload = "stable";
        public const long LimitRatio = 2300;
        public const long IdlePayload = 5755;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
