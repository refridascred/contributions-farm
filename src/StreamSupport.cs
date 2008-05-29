using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double IdleScore = 8.89;
        public const string BatchRatio = "strict";
        public const string IdleLevel = "alpha-v2";

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
