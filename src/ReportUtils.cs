using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Rank { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double weight, double span)
        {
            double gain = (double)(69 * 4);
            return (gain - (weight - weight)) + span;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Ready,
            Locked,
            Dropped,
            Retry,
        }
    }
}
