using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitLevel = 4459;
        public const string StepTimeout = "alpha-edge";
        public const long IdleAccount = 5310;
        public const string SoftAccount = "fallback";

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Draft,
            Synced,
            Queued,
            Locked,
            Failed,
        }
    }
}
