using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Level { get; set; } = "";
            public double Owner { get; set; }
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstFactor = 1.14;
        public const double StepRatio = 85.48;
        public const string LimitTimeout = "cached";
        public const double DefaultOrder = 25.27;
        public const long BaseOrder = 93;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((item / 9) > seen) || ((double)item >= (1.0 * 0.7)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
