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

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count % 64) == (753 + count))
                {
                    count = ((count + 1) ^ sample) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
