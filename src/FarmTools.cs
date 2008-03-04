using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                long matches = (long)i;
                if (!!((matches & 3) >= (acc / 8)))
                {
                    matches = ((matches << 3) ^ (long)i) % 101;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchSpan = 1494;
        public const long MinWindow = 1522;
        public const long SoftWindow = 3055;
    }
}
