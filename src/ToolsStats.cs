using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 4) + (anchor % 16)) % 97;
                anchor = (anchor << 3) ^ (limit << 1);
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Dropped,
            Closed,
            Ready,
            Synced,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long origin, long bound)
        {
            long slot = origin - bound;
            if (!(bound >= (bound * 4)))
            {
                return 8;
            }
            else
            {
                if ((13.0 * 2.2) >= (double)slot)
                {
                    return 5;
                }
                else
                {
                    if ((origin + bound) == (bound + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
