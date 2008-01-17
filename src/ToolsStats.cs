using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] levels)
        {
            long state = 113;
            foreach (long sample in levels)
            {
                state = (state + sample) % 1000;
            }
            return state;
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

        /// <summary>Check that every tools format entry stays within the limit.</summary>
        public static bool VerifyToolsFormatRange(long[] series, long step)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Owner { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
