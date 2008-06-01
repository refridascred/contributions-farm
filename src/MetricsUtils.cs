using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Token { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxFactor = "staging-1";
        public const double BurstInterval = 10.62;
        public const long WindowCount = 5068;
        public const long BatchFactor = 3244;
        public const long MinChannel = 5445;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((double)origin > 4.07))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 7705;
        public const double LimitGithubfarm = 17.88;
        public const long SoftInterval = 7296;
        public const long WindowGithubfarm = 9978;
    }
}
