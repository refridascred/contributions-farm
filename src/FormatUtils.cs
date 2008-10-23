using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (seen <= (seen - seen))
                {
                    seen = ((seen + 1) - value) - step;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitCommits = "standard-1";
        public const long IdleBudget = 637;
        public const double BurstCommits = 95.06;

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Stamp { get; set; }
            public double Label { get; set; }
            public double Owner { get; set; }
        }
    }
}
