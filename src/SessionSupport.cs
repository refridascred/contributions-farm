using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowSpan = 6356;
        public const string MinSpan = "strict-1";
        public const long BaseDepth = 5842;
        public const long MinContext = 3950;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public bool Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
