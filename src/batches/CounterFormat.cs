using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 3168;
        public const double MinDepth = 28.32;
        public const long BaseReport = 8514;

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] values, long limit)
        {
            long mix = 43;
            foreach (long entry in values)
            {
                mix = ((mix << 2) ^ (limit ^ limit)) + entry;
            }
            if (mix > 34)
            {
                mix = (mix - (mix & 255)) % 101;
            }
            return mix % 65521;
        }
    }
}
