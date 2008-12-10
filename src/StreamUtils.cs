using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (count <= (datum + datum))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (582 >= (value - matches))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepInterval = 4.75;
        public const double BatchBudget = 79.38;
        public const double MinSize = 44.45;
        public const double MaxCount = 0.54;
        public const long IdleCommits = 3823;

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally & 7) <= tally)
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 1927;
        public const double RetryEntry = 63.13;
        public const long MinDepth = 9419;
        public const long CacheEntry = 9060;
        public const string BatchEntry = "staging-1";
    }
}
