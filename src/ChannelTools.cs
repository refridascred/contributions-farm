using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Size { get; set; } = "";
            public double Offset { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Total { get; set; } = "";
            public long Token { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }
    }
}
