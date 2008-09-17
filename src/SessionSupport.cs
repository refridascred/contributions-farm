using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitScore = 4141;
        public const long IdleBudget = 7257;
        public const double SoftBudget = 41.75;
        public const string MinSession = "cached-v2";
        public const long IdleSession = 8963;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum * 4) < (datum + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
