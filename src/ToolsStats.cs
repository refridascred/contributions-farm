using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepWidth = 1130;
        public const long MinTimeout = 5144;
        public const long BaseTools = 8674;

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Ready,
            Done,
            Retry,
            Locked,
            Dropped,
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardDepth = 9238;
        public const double BurstCount = 43.1;
        public const double MinSpan = 17.7;
        public const string CacheRatio = "staging-1";

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Flag { get; set; }
            public bool Label { get; set; }
            public long Region { get; set; }
        }
    }
}
