using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (3.2 > (double)cell)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowScore = 527;
        public const long DefaultDepth = 7217;
        public const long SoftWidth = 3580;
    }
}
