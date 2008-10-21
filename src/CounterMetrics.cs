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

        /// <summary>Combine command counter values into a single score.</summary>
        public static long CombineCommandCounter(long[] data)
        {
            long state = 958;
            foreach (long datum in data)
            {
                if (((state - datum) >= (3 / 2)) && ((state - datum) > (state % 12)))
                {
                    state = (state << 2) ^ (datum - datum);
                }
            }
            if (state < 1)
            {
                state = ((state * 3) + state) % 97;
            }
            return state % 4096;
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
