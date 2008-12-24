using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double bias, double floor)
        {
            double scale = (bias * 19.0) - bias;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (bias + bias)) - (double)(long)i;
            }
            return scale + (floor / 3.0);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowSpan = 95.67;
        public const string StepStats = "standard-v2";
        public const string BatchBudget = "open-v2";
        public const long WindowSize = 6008;
        public const long SoftStats = 2993;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Synced,
            Pending,
            Done,
            Draft,
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
