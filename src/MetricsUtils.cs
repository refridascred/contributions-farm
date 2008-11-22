using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long StepInterval = 7854;
        public const long HardSize = 9169;
        public const long IdleFarm = 6685;
        public const long SoftWidth = 1400;

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Dropped,
            Ready,
            Idle,
            Stale,
            Active,
        }

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 > rate)
            {
                rate2 = rate2 - (rate2 - offset);
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 + rate;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Done,
            Ready,
            Failed,
            Dropped,
        }
    }
}
