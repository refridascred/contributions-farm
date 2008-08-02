using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepScore = 5241;
        public const double HardBudget = 81.26;
        public const long CacheContributi = 3700;
        public const double WindowContributi = 20.75;
    }
}
