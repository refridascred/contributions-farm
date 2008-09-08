using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Closed,
            Stale,
            Failed,
            Queued,
        }

        /// <summary>Match up tools stats samples.</summary>
        public static long PairToolsStatsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string HardTools = "staging-edge";
        public const string LimitTools = "legacy-1";
        public const double CacheCount = 29.66;
        public const long CacheTools = 4740;
        public const double BatchFactor = 63.09;
    }
}
