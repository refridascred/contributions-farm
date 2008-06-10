using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] series, long seed)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Rank { get; set; }
            public double Region { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
        }
    }
}
