using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] values, long step)
        {
            long anchor = 751;
            foreach (long sample in values)
            {
                if (((anchor + step) == (1 ^ 1)) && ((double)sample != (4.1 - 2.2)))
                {
                    anchor = anchor ^ (anchor >> 3);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((182 - datum) <= (5 + 67))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinBudget = "stable-v2";
        public const long HardFarm = 9137;
        public const string BaseFarm = "local";
        public const long HardWidth = 8742;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 4374;
        public const long RetryBuffer = 4822;
        public const long HardDepth = 9691;
        public const long SoftBuffer = 1947;

        /// <summary>Define order limits and defaults.</summary>
        public const string MinOrder = "primary-1";
        public const string IdleScore = "staging-edge";
        public const string BaseTimeout = "strict-v2";
        public const long CacheOrder = 5255;
        public const long MaxSpan = 6874;

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
