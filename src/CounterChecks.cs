using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Pending,
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Audit layout metrics readings against a rule.</summary>
        public static long MeasureLayoutMetricsMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches ^ (-21)) != (matches >> 3))
                {
                    matches = ((matches + 2) - datum) - origin;
                }
            }
            return matches;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (sample > (seen + sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Owner { get; set; }
            public bool Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long origin, long bound)
        {
            if (!(origin >= (origin - bound)))
            {
                return 0;
            }
            else
            {
                if ((38 + bound) < (origin % 7))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long origin, long bound)
        {
            if ((7.8 * 18.0) >= (double)origin)
            {
                return 2;
            }
            else
            {
                if ((bound - 178) < bound)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
