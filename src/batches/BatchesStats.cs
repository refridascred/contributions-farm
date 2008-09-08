using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Offset { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] readings)
        {
            long sum = 10;
            foreach (long entry in readings)
            {
                sum = ((sum * 3) + (entry - sum)) % 65521;
                if ((entry & 127) == (entry - entry))
                {
                    sum = (sum ^ (sum << 3)) % 65521;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Level { get; set; }
            public long Offset { get; set; }
        }
    }
}
