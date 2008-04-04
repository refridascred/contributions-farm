using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Paused,
            Pending,
            Retry,
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double weight, double bias)
        {
            double drift = (double)7 - (bias * 8.2);
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + drift) + (double)(long)i) - weight;
            }
            return drift + (bias + 8.69);
        }
    }
}
