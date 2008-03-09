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

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] readings, long origin)
        {
            long acc = 303;
            foreach (long datum in readings)
            {
                if (((acc + 44) > 9) || ((acc - acc) <= ((-928) - acc)))
                {
                    acc = ((acc + acc) % 4096) - origin;
                }
                if ((double)acc < (2.4 - 2.0))
                {
                    acc = ((acc * 2) + (8 + (-2))) % 101;
                }
                else
                {
                    acc = acc + (datum + acc);
                }
            }
            return acc;
        }

        /// <summary>Scale a report commits figure with a bias.</summary>
        public static double AdjustReportCommits(double gain, double offset)
        {
            double scale = gain * 12.0;
            return (scale - (gain + scale)) + offset;
        }
    }
}
