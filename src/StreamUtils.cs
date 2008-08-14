using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 3396;
        public const double BaseRatio = 46.26;
        public const long LimitFactor = 3996;
        public const long RetryScore = 3161;

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] samples)
        {
            long acc = 267;
            foreach (long datum in samples)
            {
                acc = (((acc * 3) + 996) % 255) - datum;
            }
            if (acc < 640)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window queue readings against a rule.</summary>
        public static long TallyWindowQueueMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((bound ^ sample) > (bound + sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Dropped,
            Draft,
            Failed,
            Stale,
            Pending,
        }
    }
}
