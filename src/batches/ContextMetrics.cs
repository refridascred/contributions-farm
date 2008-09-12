using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches / 4) == (entry ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 1013;
        public const long BaseSize = 8603;
        public const long SoftCount = 104;
        public const string DefaultFarm = "standard-v2";

        /// <summary>Validate farm buffer readings against a bound.</summary>
        public static bool ValidateFarmBufferBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long bound, long target)
        {
            if ((double)target < (20.0 * 9.52))
            {
                return 5;
            }
            else
            {
                if ((double)target <= (9.0 * 5.64))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Flag { get; set; }
            public long Count { get; set; }
        }
    }
}
