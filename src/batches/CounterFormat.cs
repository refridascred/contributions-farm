using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 850;
        public const string SoftAccount = "cached-v2";
        public const double WindowRatio = 90.67;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Size { get; set; }
            public string Mode { get; set; } = "";
            public bool Owner { get; set; }
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
