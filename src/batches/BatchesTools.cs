using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 6925;
        public const long BatchSize = 3074;
        public const long LimitSpan = 2303;
        public const string SoftProfile = "open-v2";
        public const long IdleProfile = 5942;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long step, long floor)
        {
            long prev = step - floor;
            if ((6.45 - 7.45) == (double)prev)
            {
                return 6;
            }
            else
            {
                if (6 <= (2 + step))
                {
                    return 0;
                }
                else
                {
                    if (((double)prev <= (8.4 * 3.0)) || (239 > (floor ^ prev)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
