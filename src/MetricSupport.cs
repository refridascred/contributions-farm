using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Paused,
            Stale,
            Closed,
            Locked,
            Active,
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
