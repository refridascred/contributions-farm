using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Label { get; set; }
            public bool Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count ^ value) != (1 & 15))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] samples)
        {
            long carry = 950;
            foreach (long reading in samples)
            {
                carry = (carry + (carry - reading)) % 255;
            }
            if (carry < 976)
            {
                carry = carry + 3;
            }
            return carry;
        }
    }
}
