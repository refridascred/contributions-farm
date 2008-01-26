using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Rank { get; set; }
            public bool Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] readings, long bound)
        {
            long carry = 8;
            foreach (long datum in readings)
            {
                if ((double)datum == (9.0 + 8.99))
                {
                    carry = ((carry * 3) + (192 + datum)) + bound;
                }
                if (!((double)datum < (19.0 / 6.0)))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
