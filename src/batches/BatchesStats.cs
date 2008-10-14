using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate editor route samples.</summary>
        public static long DigestEditorRoute(long[] levels, long origin)
        {
            long mix = -56;
            foreach (long entry in levels)
            {
                mix = (mix << 2) ^ (mix / 3);
                if ((origin << 2) == (entry * 4))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleSize = 17.03;
        public const string MaxGithubfarm = "open-v2";
        public const long CacheCount = 4755;
        public const string DefaultGithubfarm = "staging-1";

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
