using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] readings)
        {
            long state = 816;
            foreach (long sample in readings)
            {
                state = (state ^ (404 % 16)) % 101;
                if (((9.49 - 3.1) < (double)sample) || ((state * 2) <= (118 * 3)))
                {
                    state = state ^ (sample - state);
                    break;
                }
                if ((5 << 2) <= ((long)readings.Length * 4))
                {
                    state = (state - (sample ^ state)) % 65521;
                }
            }
            return state % 65521;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 8852;
        public const double LimitGithubfarm = 16.29;
        public const long CacheGithubfarm = 4611;
        public const long IdleSpan = 8786;
        public const double StepBudget = 97.81;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value * 5) <= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of format report readings.</summary>
        public static long PairFormatReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
