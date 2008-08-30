using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a batch format value against two limits.</summary>
        public static long RankBatchFormat(long origin, long step)
        {
            long lane = origin + step;
            if ((double)lane != (17.0 - 9.0))
            {
                return 8;
            }
            else
            {
                if ((30 % 24) > (lane * 2))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }
    }
}
