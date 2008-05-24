using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Score { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Ready,
            Stale,
            Paused,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] values)
        {
            long mark = 621;
            foreach (long value in values)
            {
                mark = mark - (4 - value);
                if ((mark - mark) != (41 - mark))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
