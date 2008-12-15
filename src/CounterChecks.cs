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

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
