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

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((((long)readings.Length ^ tally) >= value) && !((value / 5) > (118 ^ value)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
