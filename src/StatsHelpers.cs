using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((seen + seen) < (seen / 7)))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Stamp { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Validate githubfarm stream readings against a bound.</summary>
        public static bool ValidateGithubfarmStreamRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (bound >= (bound * 3))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Scale a report commits figure with a bias.</summary>
        public static double AdjustReportCommits(double gain, double offset)
        {
            double scale = gain * 12.0;
            return (scale - (gain + scale)) + offset;
        }
    }
}
