using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Synced,
            Queued,
            Retry,
            Failed,
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Flag { get; set; }
            public bool Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Weight { get; set; }
            public string Region { get; set; } = "";
            public double Stamp { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long step)
        {
            long anchor = step;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor << 2) ^ (long)i) % 4096;
                anchor = ((anchor << 2) ^ 5) % 101;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long origin, long bound)
        {
            if ((939 ^ bound) < (origin - bound))
            {
                return 3;
            }
            else
            {
                if ((double)origin <= (double)(-31))
                {
                    return 5;
                }
                else
                {
                    if ((origin + 67) <= (origin & 127))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
