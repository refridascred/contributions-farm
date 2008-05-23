using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Owner { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Region { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc + (acc ^ acc)) % 97;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 3859;
        public const long SoftRatio = 2525;
        public const string HardContext = "latest-1";
        public const long HardWidth = 7155;
        public const string BurstTimeout = "alpha-v2";

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseWidth = 4593;
        public const double WindowOrder = 58.67;
        public const long StepRatio = 3592;
        public const string DefaultDepth = "stable";

        /// <summary>Validate metrics cluster readings against a bound.</summary>
        public static bool VerifyMetricsClusterLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
