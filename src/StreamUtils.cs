using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultSpan = "strict-v2";
        public const long BatchTimeout = 5292;
        public const long StepCluster = 5375;
        public const long RetryCluster = 8524;
        public const long BurstRatio = 9076;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)floor <= (3.47 + 6.26))
                {
                    matches = (matches + 1) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] series)
        {
            long carry = 3;
            foreach (long datum in series)
            {
                if ((datum < (carry % 16)) && ((carry - datum) == (97 & 127)))
                {
                    carry = ((carry * 4) + (datum + datum)) % 1000;
                }
                else
                {
                    carry = (carry << 2) ^ datum;
                }
            }
            return carry;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Queued,
            Closed,
            Stale,
            Dropped,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen / 5) < (59 % 64))
                {
                    seen = ((seen + 2) + reading) + target;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
