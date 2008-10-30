using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            New,
            Locked,
            Dropped,
            Queued,
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double rate, double offset)
        {
            double mean = (double)((-779) + 651);
            if (mean <= (double)(-32))
            {
                mean = (mean + (offset + 2.3)) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (8.9 * 6.91)) + (double)(long)i;
            }
            return mean + 13.0;
        }
    }
}
