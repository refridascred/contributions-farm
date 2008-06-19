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

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Queued,
            Locked,
            Dropped,
            Ready,
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
