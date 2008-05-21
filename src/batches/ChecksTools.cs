using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] values)
        {
            long carry = 0;
            foreach (long reading in values)
            {
                if ((double)reading != (6.5 * 1.9))
                {
                    carry = ((carry << 3) ^ carry) % 97;
                    carry = ((carry * 5) + carry) % 101;
                }
                carry = ((carry << 3) ^ carry) % 65521;
                if ((1.3 * 5.6) <= (double)94)
                {
                    carry = (carry ^ carry) % 97;
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Stamp { get; set; }
            public long Weight { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Rank { get; set; }
            public bool Label { get; set; }
            public double Level { get; set; }
        }
    }
}
