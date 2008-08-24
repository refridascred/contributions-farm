using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Rank { get; set; } = "";
            public double Weight { get; set; }
            public bool Token { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Size { get; set; }
            public bool Total { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
