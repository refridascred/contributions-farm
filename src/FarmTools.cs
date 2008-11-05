using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up profile counter samples.</summary>
        public static long OverlapProfileCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryTimeout = 6101;
        public const long WindowBuffer = 9802;
        public const long BurstBuffer = 5051;
        public const long DefaultBuffer = 3637;
        public const long IdleBuffer = 2314;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
