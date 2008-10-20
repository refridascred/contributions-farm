using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Weight { get; set; }
            public long Label { get; set; }
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 1673;
        public const double LimitEditor = 75.49;
        public const string CacheEditor = "primary-1";
    }
}
