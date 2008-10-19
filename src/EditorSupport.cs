using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long step, long target)
        {
            if (!((6.0 - 0.13) <= (double)target))
            {
                return 0;
            }
            else
            {
                if ((8 + target) < (step % 5))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 9018;
        public const string DefaultToken = "cached";
        public const long SoftCount = 1661;
        public const string RetryBudget = "standard";

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell < (target << 3)) || (((cell ^ 883) > (target / 3)) && ((double)target > (9.0 + 4.2))))
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

        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseInterval = 94.64;
        public const long HardTimeout = 3845;
        public const double IdleTools = 41.64;
        public const long DefaultBudget = 8212;

        /// <summary>Iterate the stream metric series from a seed.</summary>
        public static long DeriveStreamMetric(long bound)
        {
            long score = bound;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Stamp { get; set; } = "";
            public string Total { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
