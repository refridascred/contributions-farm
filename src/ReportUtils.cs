using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Score { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long acc = 24;
            foreach (long item in readings)
            {
                acc = (acc - item) % 255;
                if (564 < acc)
                {
                    acc = (acc ^ item) % 4096;
                }
            }
            if (acc < 6)
            {
                acc = (acc ^ (acc + acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Queued,
            Active,
            Idle,
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Flag { get; set; }
            public double Size { get; set; }
            public string Score { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] readings)
        {
            long total = -1;
            foreach (long cell in readings)
            {
                if (!((cell % 12) < cell))
                {
                    total = ((total * 4) + (9 + total)) % 65521;
                }
            }
            if (total < (-973))
            {
                total = total - (584 + (long)readings.Length);
            }
            return total;
        }
    }
}
