using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Token { get; set; } = "";
            public long Region { get; set; }
            public double Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardSize = "latest";
        public const long LimitBatch = 4009;
        public const string IdleBatch = "primary-edge";
        public const long DefaultBatch = 1852;
        public const long LimitDepth = 6249;
    }
}
