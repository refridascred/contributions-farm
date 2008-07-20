using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double StepInterval = 6.05;
        public const string BaseLayout = "strict-v2";
        public const long SoftCount = 3084;

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long seed, long target)
        {
            if (((target * 4) >= target) || ((seed % 64) > (5 << 2)))
            {
                return 8;
            }
            else
            {
                if ((seed > 0) || ((seed << 1) <= (seed ^ target)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
