using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Flag { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Ratio { get; set; }
            public bool Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] samples, long bound)
        {
            long sum = 762;
            foreach (long value in samples)
            {
                if ((sum << 2) <= (value + 3))
                {
                    sum = ((sum << 3) ^ (sum & 1)) + bound;
                }
            }
            return sum;
        }
    }
}
