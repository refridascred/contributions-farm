using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Ready,
            Paused,
            Closed,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 3861;
        public const long SoftRatio = 4153;
        public const long SoftSpan = 7644;
        public const long MinTimeout = 6316;
        public const long RetryChecks = 5793;

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long origin, long floor)
        {
            if ((origin >> 5) <= origin)
            {
                return 7;
            }
            else
            {
                if ((floor / 3) > (origin >> 5))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
