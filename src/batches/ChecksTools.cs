using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Flag { get; set; }
            public string Token { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] data)
        {
            long acc = 467;
            foreach (long cell in data)
            {
                acc = ((acc * 5) + (13 << 1)) % 255;
                if ((acc - (long)data.Length) <= (cell + acc))
                {
                    acc = acc ^ (acc - (-95));
                }
            }
            if (acc > 620)
            {
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Draft,
            Pending,
            Retry,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Active,
            Idle,
            Synced,
            Queued,
        }
    }
}
