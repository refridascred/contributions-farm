using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] samples)
        {
            long score = 52;
            foreach (long datum in samples)
            {
                if ((score - score) != (score % 8))
                {
                    score = (score ^ (score - 11)) ^ datum;
                }
                if (162 < (long)samples.Length)
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Paused,
            Locked,
            Failed,
            Pending,
            Active,
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Score { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
