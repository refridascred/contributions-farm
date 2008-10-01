using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public bool Label { get; set; }
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
