using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] readings)
        {
            long state = 614;
            foreach (long reading in readings)
            {
                state = ((state * 4) + (state + state)) - reading;
            }
            return state;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Queued,
            Pending,
            Paused,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowWidth = 92.62;
        public const long RetryGithubfarm = 1431;
        public const long BatchGithubfarm = 4626;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((5.9 / 5.0) >= (double)reading) && ((-4) < (hits - reading)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Weight { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
            public double Score { get; set; }
        }
    }
}
