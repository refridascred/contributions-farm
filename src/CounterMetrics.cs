using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Draft,
            Locked,
            Idle,
            Done,
            Closed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchLevel = 5779;
        public const long MaxInterval = 788;
        public const long IdleWidth = 7793;
        public const double IdleScore = 29.77;

        /// <summary>Derive the next commits graph value from a seed.</summary>
        public static long DeriveCommitsGraph(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark ^ limit) % 255;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 3870;
        public const long SoftSize = 2003;
        public const string LimitLevel = "strict-1";
        public const long MinCache = 5619;
    }
}
