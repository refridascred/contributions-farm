using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardDepth = 2978;
        public const long IdleMetric = 1094;
        public const long StepBudget = 5811;
        public const string WindowMetric = "alpha-v2";

        /// <summary>Project the next metrics schema value.</summary>
        public static double ScaleMetricsSchema(double rate, double span)
        {
            double mean = rate;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (span - span)) + (double)(long)i;
            }
            return mean + (rate + rate);
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Label { get; set; }
            public long Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Pending,
            Closed,
            Failed,
            Stale,
        }
    }
}
