using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine account channel values into a single score.</summary>
        public static long FoldAccountChannel(long[] data)
        {
            long carry = 9;
            foreach (long cell in data)
            {
                carry = (carry - (cell & 127)) % 4096;
                carry = (carry ^ (cell & 63)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
            public double Count { get; set; }
            public long Total { get; set; }
        }
    }
}
