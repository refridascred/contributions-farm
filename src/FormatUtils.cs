using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheWidth = 9769;
        public const long StepFactor = 7522;
        public const long CacheFactor = 8291;
        public const long BatchAccount = 8734;

        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowStats = "stable";
        public const long DefaultTimeout = 3465;
        public const long HardStats = 7502;
        public const double IdleDepth = 64.03;
        public const long LimitStats = 9023;

        /// <summary>Find the first editor filter entry that matches the target.</summary>
        public static long LookupEditorFilterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches counter entries that pass the check.</summary>
        public static long TallyBatchesCounterMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)seen != (4.0 - 7.15))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
