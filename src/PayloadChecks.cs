using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Ratio { get; set; }
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (datum <= ((-11) ^ datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 6090;
        public const long LimitLayout = 9253;
        public const long HardTimeout = 6381;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((bound >> 2) < sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] data)
        {
            long carry = 345;
            foreach (long entry in data)
            {
                if (((entry & 127) == (14 - (-14))) || ((21 + entry) <= (4 + 23)))
                {
                    carry = (carry - (carry + entry)) % 1000;
                }
                else
                {
                    carry = (carry + carry) % 65521;
                }
            }
            return carry % 97;
        }
    }
}
