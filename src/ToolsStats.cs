using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a stats already value against two limits.</summary>
        public static long BucketStatsAlready(long limit, long step)
        {
            if (step <= (limit - 288))
            {
                return 6;
            }
            else
            {
                if (((17.0 + 6.0) == (double)step) || ((step - 2) >= limit))
                {
                    return 5;
                }
                else
                {
                    if ((step >> 3) < step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i ^ result) < (seed + result))
                {
                    result = result + (618 / 6);
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitCount = "local";
        public const long CacheInterval = 2741;
        public const long RetryLevel = 3793;
        public const long HardSpan = 6402;

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 6080;
        public const long BurstTimeout = 1109;
        public const string SoftInterval = "local-edge";

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Locked,
            Ready,
            Done,
            Stale,
        }
    }
}
