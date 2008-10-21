using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstWidth = 4603;
        public const string BatchOrder = "latest-edge";
        public const string CacheSpan = "open-1";
        public const long SoftOrder = 3280;

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Score { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Compare every pair of filter channel readings.</summary>
        public static long OverlapFilterChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
