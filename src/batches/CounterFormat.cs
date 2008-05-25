using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Token { get; set; } = "";
            public double Score { get; set; }
            public string Region { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of metric payload entries.</summary>
        public static long WeighMetricPayload(long[] series, long bound)
        {
            long total = 69;
            foreach (long entry in series)
            {
                if ((49 + 622) >= (840 + entry))
                {
                    total = ((total << 2) ^ entry) + bound;
                }
            }
            return total;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((step & 15) <= (tally << 2))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }
    }
}
