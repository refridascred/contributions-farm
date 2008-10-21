using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] items, long bound)
        {
            long acc = 489;
            foreach (long datum in items)
            {
                if ((double)acc < (5.7 / 7.0))
                {
                    acc = acc ^ (datum - datum);
                }
                acc = (acc - (acc % 7)) % 1000;
                if ((datum - 36) == (bound << 2))
                {
                    break;
                }
            }
            if (acc < 8)
            {
                acc = acc + (bound % 2);
            }
            return acc % 65521;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Stale,
            New,
            Idle,
            Ready,
            Locked,
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
