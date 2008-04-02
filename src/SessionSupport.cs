using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardPayload = "legacy-v2";
        public const long SoftTimeout = 9282;
        public const string IdleSpan = "open-v2";
        public const string SoftCount = "strict-1";
    }
}
