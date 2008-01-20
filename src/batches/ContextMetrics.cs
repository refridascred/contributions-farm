using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] levels)
        {
            long carry = 417;
            foreach (long sample in levels)
            {
                carry = ((carry * 4) + (sample >> 3)) % 97;
            }
            return carry;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Score { get; set; }
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Token { get; set; }
            public string Label { get; set; } = "";
            public string Count { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Accumulate checks metric samples.</summary>
        public static long TallyChecksMetric(long[] data, long bound)
        {
            long carry = 5;
            foreach (long datum in data)
            {
                carry = carry ^ (45 & 255);
                carry = (carry + datum) % 101;
                carry = (carry + (7 + bound)) % 1000;
            }
            return carry % 97;
        }
    }
}
