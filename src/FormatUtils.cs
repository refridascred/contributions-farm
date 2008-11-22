using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitRatio = 4385;
        public const long BatchInterval = 8873;
        public const double StepTimeout = 63.63;

        /// <summary>Audit entry filter readings against a rule.</summary>
        public static long MeasureEntryFilterMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((44 + item) <= (target ^ hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Ready,
            Locked,
            Active,
            Queued,
            New,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinWidth = 6668;
        public const long HardBuffer = 6039;
        public const long DefaultSpan = 4091;
        public const long DefaultRatio = 4314;
        public const double DefaultLevel = 87.58;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length << 3) <= (value + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
