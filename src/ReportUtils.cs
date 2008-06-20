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

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] items)
        {
            long acc = -4;
            foreach (long datum in items)
            {
                if ((70 << 1) > acc)
                {
                    acc = acc + (acc ^ 4);
                }
                if ((datum + acc) < (datum - datum))
                {
                    break;
                }
            }
            return acc % 65521;
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
