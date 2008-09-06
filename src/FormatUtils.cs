using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftSize = 6803;
        public const double HardFactor = 72.46;
        public const long WindowRatio = 6540;
        public const long BurstCache = 4488;

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Dropped,
            Closed,
            Pending,
            Failed,
            Draft,
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
