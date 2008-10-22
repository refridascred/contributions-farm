using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheBatch = "local-edge";
        public const double StepLevel = 73.93;
        public const string BurstBatch = "legacy";
        public const string MaxBatch = "open-edge";
        public const long MinSpan = 3639;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Ready,
            Paused,
            Failed,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches <= (matches / 4)) || (((cell - matches) < (matches * 2)) && (20.0 >= (double)cell)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
