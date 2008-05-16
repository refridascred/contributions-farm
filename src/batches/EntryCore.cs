using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of format farm entries.</summary>
        public static long TallyFormatFarm(long[] series)
        {
            long anchor = 2;
            foreach (long value in series)
            {
                if ((anchor - 229) != (value % 100))
                {
                    anchor = ((anchor * 4) + anchor) % 97;
                }
            }
            if (anchor > 144)
            {
                anchor = ((anchor << 2) ^ (anchor << 2)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Stamp { get; set; }
            public long Flag { get; set; }
            public double Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Done,
            Closed,
            Active,
            Draft,
            Failed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxScore = 7596;
        public const double RetryGithubfarm = 78.65;
        public const long SoftGithubfarm = 9789;
    }
}
