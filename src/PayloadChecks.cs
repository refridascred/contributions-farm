using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Score { get; set; }
            public string Size { get; set; } = "";
            public double Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Dropped,
            Done,
            Paused,
            Stale,
            New,
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Limit { get; set; }
            public string Size { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Dropped,
            Paused,
            Synced,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long origin, long target)
        {
            long step = origin - target;
            if (((step / 9) != (35 % 64)) && (origin <= (target - 8)))
            {
                return 0;
            }
            else
            {
                if (((origin ^ target) == (5 + target)) && ((double)step <= 7.0))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double ratio, double offset)
        {
            double scale = (offset + offset) - (ratio / 7.0);
            if (scale > scale)
            {
                scale = scale - offset;
            }
            else
            {
                scale = scale - (scale / 8.0);
            }
            return scale - (offset - 5.72);
        }
    }
}
