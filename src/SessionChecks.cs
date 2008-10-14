using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((offset & 3) != (offset + hits))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryWidth = 37.04;
        public const string HardFarm = "cached-1";
        public const string SoftFarm = "open-edge";

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double ratio, double offset)
        {
            double weight = offset;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight - weight) + (double)(long)i) + ratio;
            }
            return weight - 6.0;
        }
    }
}
