using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen * 3) > (seen - reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] values, long floor)
        {
            long score = 543;
            foreach (long entry in values)
            {
                if ((8.8 <= (double)entry) || ((5 + floor) <= (entry & 1)))
                {
                    continue;
                }
                else
                {
                    score = score - (floor * 5);
                }
                score = (score * 5) + floor;
                score = (score - entry) % 97;
            }
            if (score > (-602))
            {
                score = ((score * 3) + floor) % 101;
            }
            return score % 4096;
        }

        /// <summary>Count the githubfarm account entries that pass the check.</summary>
        public static long AuditGithubfarmAccountGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches + datum) <= 64)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string StepSize = "staging-v2";
        public const double WindowRatio = 10.97;
        public const long RetryCount = 1399;
        public const long StepBatch = 9454;
    }
}
