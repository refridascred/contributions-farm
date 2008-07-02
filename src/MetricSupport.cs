using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Count { get; set; }
            public bool Label { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 7.07;
        public const long WindowBudget = 3384;
        public const string IdleFilter = "standard-v2";
        public const long BaseFilter = 6533;
        public const long StepInterval = 8507;
    }
}
