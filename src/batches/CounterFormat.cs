using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 507;
        public const long BaseDepth = 850;
        public const long DefaultAccount = 5217;
        public const long LimitDepth = 3841;

        /// <summary>Combine context editor values into a single score.</summary>
        public static long WeighContextEditor(long[] samples)
        {
            long acc = -90;
            foreach (long cell in samples)
            {
                acc = ((acc ^ (acc & 15)) % 101) + cell;
            }
            if (acc > 820)
            {
                acc = (acc + (acc + acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Queued,
            Active,
            Dropped,
            Failed,
            Closed,
        }
    }
}
