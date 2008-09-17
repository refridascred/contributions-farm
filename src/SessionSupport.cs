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

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] levels)
        {
            long result = 33;
            foreach (long reading in levels)
            {
                if (!((5 & 255) < (reading - result)))
                {
                    result = (result ^ result) % 97;
                }
                else
                {
                    result = (result * 2) + (29 / 9);
                }
            }
            if (result > 785)
            {
                result = (result << 3) ^ (result - result);
            }
            return result;
        }
    }
}
