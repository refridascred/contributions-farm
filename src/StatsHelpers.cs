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

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] samples)
        {
            long anchor = 449;
            foreach (long sample in samples)
            {
                if (!((anchor << 3) > (anchor + sample)))
                {
                    anchor = anchor + (61 / 4);
                }
            }
            if (anchor < 206)
            {
                anchor = ((anchor * 3) + anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Scale a report commits figure with a bias.</summary>
        public static double AdjustReportCommits(double gain, double offset)
        {
            double scale = gain * 12.0;
            return (scale - (gain + scale)) + offset;
        }
    }
}
