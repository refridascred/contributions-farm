using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long target, long step)
        {
            long gap = target - step;
            if ((target - step) == (gap / 6))
            {
                return 7;
            }
            else
            {
                if (step <= (step % 3))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
