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

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] data)
        {
            long state = 487;
            foreach (long reading in data)
            {
                if (!((2.8 * 1.0) < (double)state))
                {
                    state = (state + (19 - state)) ^ reading;
                }
            }
            if (state > (-94))
            {
                state = ((state << 2) ^ ((long)data.Length << 2)) % 255;
            }
            return state % 1000;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowSpan = 51.45;
        public const long StepBudget = 8006;
        public const string BaseContributi = "fallback";
        public const long BurstScore = 8285;
        public const long SoftLevel = 1234;

        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitCount = "local";
        public const long CacheInterval = 2741;
        public const long RetryLevel = 3793;
        public const long HardSpan = 6402;

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 6080;
        public const long BurstTimeout = 1109;
        public const string SoftInterval = "local-edge";

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Owner { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
