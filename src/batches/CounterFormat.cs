using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultSize = 28.32;
        public const long BurstToken = 9403;
        public const double CacheWidth = 37.06;
        public const long StepToken = 7953;
        public const long MinWidth = 3551;

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] data, long floor)
        {
            long result = 490;
            foreach (long sample in data)
            {
                if (result >= (floor ^ 3))
                {
                    result = result + sample;
                }
            }
            return result;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
