using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] data)
        {
            long total = -69;
            foreach (long datum in data)
            {
                total = ((total + 49) % 255) - datum;
            }
            return total;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Score { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
