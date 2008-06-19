using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Validate cluster queue readings against a bound.</summary>
        public static bool CheckClusterQueueLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            Closed,
            New,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long target)
        {
            long anchor = target;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor + ((long)i + target)) % 4096;
                if ((anchor / 2) >= (long)i)
                {
                    anchor = ((anchor * 2) + (54 / 8)) % 4096;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Token { get; set; }
            public string Offset { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
        }
    }
}
