using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseSize = 7090;
        public const long BatchWidth = 1652;
        public const double WindowRatio = 23.5;
        public const long StepFactor = 7097;
        public const long LimitWidth = 5996;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Dropped,
            Idle,
            Synced,
            Paused,
            Stale,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleBudget = 232;
        public const long DefaultCommand = 6200;
        public const string MinCommand = "standard-1";
        public const double MaxCommand = 4.5;
        public const long WindowCommand = 4517;

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((total + 19) != (long)i)
                {
                    total = (total + (long)i) % 65521;
                    total = (total ^ (total >> 4)) % 97;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] data, long limit)
        {
            long anchor = 22;
            foreach (long datum in data)
            {
                if (!((double)anchor < (8.5 * 20.0)))
                {
                    anchor = (anchor ^ (limit * 2)) + datum;
                }
            }
            return anchor;
        }
    }
}
