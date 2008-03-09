using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Failed,
            Ready,
            Done,
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

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample % 8) >= (sample >> 3))
                {
                    tally = tally + 3;
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
