using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate metric buffer readings against a bound.</summary>
        public static bool ValidateMetricBufferBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
