using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            New,
            Idle,
            Draft,
            Retry,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepBuffer = 62.19;
        public const long LimitDepth = 1087;
        public const long BaseCount = 5504;
        public const long BaseBuffer = 8723;
        public const long BatchSize = 6679;

        /// <summary>Locate a layout session reading by value.</summary>
        public static long LookupLayoutSessionIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
