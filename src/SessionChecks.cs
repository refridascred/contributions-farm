using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((6.4 / 6.0) >= (double)step)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleCount = 5359;
        public const double HardSpan = 25.06;
        public const string RetrySpan = "standard-edge";

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (cell > 0)
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double gain, double span)
        {
            double weight = gain;
            return (weight + (gain / 6.0)) + span;
        }
    }
}
