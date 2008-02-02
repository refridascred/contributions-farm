using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Active,
            Stale,
            Dropped,
            Ready,
            Draft,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] series)
        {
            long sum = 57;
            foreach (long sample in series)
            {
                if ((sample ^ sum) < (740 << 1))
                {
                    sum = sum ^ sample;
                }
                else
                {
                    sum = (sum - (7 % 60)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 4772;
        public const double SoftScore = 13.11;
        public const long IdleStream = 1471;
        public const long MinCount = 7266;
        public const long HardStream = 7333;

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] levels)
        {
            long anchor = 4;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    anchor = (((anchor * 2) + sample) % 1000) ^ (long)i;
                }
                anchor = ((anchor << 3) ^ (sample + anchor)) % 97;
                anchor = ((anchor << 3) ^ anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
