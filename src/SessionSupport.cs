using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string CacheRecord = "local-v2";
        public const long MinInterval = 546;
        public const long DefaultRecord = 1552;
        public const string BatchRatio = "latest-v2";

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Mode { get; set; } = "";
            public double Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
