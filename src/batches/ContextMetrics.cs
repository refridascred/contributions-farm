using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Synced,
            Retry,
            Queued,
            Pending,
            Idle,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] levels, long target)
        {
            long state = 369;
            foreach (long sample in levels)
            {
                state = (state * 3) + target;
                if ((target & 255) >= target)
                {
                    state = state - (sample - sample);
                }
            }
            return state % 1000;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Label { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchWidth = 4743;
        public const long StepCache = 2338;
        public const long WindowCache = 4246;
        public const long IdleCache = 2809;
        public const double BatchInterval = 63.55;
    }
}
