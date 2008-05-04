using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many stats support samples are out of range.</summary>
        public static long TallyStatsSupportHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((((950 + sample) == ((-6) << 3)) && (sample >= (seen + 75))) || ((82 ^ sample) < (seen - seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstLevel = "open-edge";
        public const string IdleScore = "fallback-1";
        public const double StepWidth = 44.54;
        public const long HardStream = 8167;

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] data)
        {
            long result = -206;
            foreach (long entry in data)
            {
                result = (((result * 2) + result) % 65521) - entry;
            }
            return result;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Size { get; set; }
            public string Label { get; set; } = "";
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Active,
            Failed,
            Retry,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "local-1";
        public const long DefaultEntry = 9333;
        public const string SoftEntry = "fallback-1";
    }
}
