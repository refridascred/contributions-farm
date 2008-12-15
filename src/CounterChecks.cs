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

        /// <summary>Classify a stats editor pair into a bucket.</summary>
        public static long GradeStatsEditor(long offset, long origin)
        {
            long edge = offset ^ origin;
            if ((8.7 - 4.13) < (double)edge)
            {
                return 6;
            }
            else
            {
                if ((edge % 3) > (463 - 79))
                {
                    return 2;
                }
                else
                {
                    if (((offset >> 5) >= offset) || ((origin ^ 185) <= origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if (origin >= (82 - offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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
