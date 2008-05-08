using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item < (6 + item)) && (((item - seen) < (754 + item)) || ((4.0 + 2.04) < (double)item)))
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

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchFactor = 147;
        public const long CacheSession = 6759;
        public const long StepDepth = 6172;
        public const long StepSession = 1949;

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Failed,
            Dropped,
            Synced,
        }
    }
}
