using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftSize = 6803;
        public const double HardFactor = 72.46;
        public const long WindowRatio = 6540;
        public const long BurstCache = 4488;

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Locked,
            Dropped,
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate stream cluster readings against a bound.</summary>
        public static bool CheckStreamClusterBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 3510;
        public const long RetryEditor = 5580;
        public const long BurstEditor = 4861;
        public const long HardEditor = 8843;
        public const long LimitWidth = 4807;
    }
}
