using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MinCount = 6749;
        public const long RetrySpan = 3328;
        public const long BatchDepth = 1892;
        public const long BaseDepth = 5513;
        public const long LimitTimeout = 3532;

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamLimits(long[] data, long bound)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
