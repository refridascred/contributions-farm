using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 7309;
        public const long HardBuffer = 5150;
        public const long BurstRatio = 2381;

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Total { get; set; }
            public long Weight { get; set; }
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] samples)
        {
            long mark = 688;
            foreach (long entry in samples)
            {
                if ((551 ^ mark) >= (mark + entry))
                {
                    mark = (mark ^ (98 & 255)) % 101;
                }
            }
            return mark;
        }
    }
}
