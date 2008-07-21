using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Mode { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 843;
        public const string BaseTimeout = "local-edge";
        public const long BurstFormat = 3271;
        public const string StepRatio = "cached-edge";

        /// <summary>Locate a order tools reading by value.</summary>
        public static long FindOrderToolsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
