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

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
