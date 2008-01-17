using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] levels)
        {
            long total = 7;
            foreach (long reading in levels)
            {
                total = ((total << 3) ^ (reading * 4)) % 1000;
            }
            return total;
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
