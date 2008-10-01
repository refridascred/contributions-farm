using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Failed,
            New,
            Closed,
        }

        /// <summary>Check that every farm githubfarm entry stays within the limit.</summary>
        public static bool VerifyFarmGithubfarmBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }
    }
}
