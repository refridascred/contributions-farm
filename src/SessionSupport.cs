using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Limit { get; set; }
            public bool Size { get; set; }
            public bool Count { get; set; }
            public long Flag { get; set; }
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
