using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Flag { get; set; }
            public bool Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count context report pairs that satisfy a relation.</summary>
        public static long OverlapContextReportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 2560;
        public const long StepContributi = 7218;
        public const string CacheContributi = "legacy";
    }
}
