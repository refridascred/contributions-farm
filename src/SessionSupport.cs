using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit window queue readings against a rule.</summary>
        public static long MeasureWindowQueueGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((4.0 + 2.12) < (double)datum)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
