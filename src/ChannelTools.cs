using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "cached";
        public const string BurstCache = "local-v2";
        public const long WindowSpan = 221;
        public const double BurstSpan = 85.22;
        public const string SoftSize = "strict-v2";

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
