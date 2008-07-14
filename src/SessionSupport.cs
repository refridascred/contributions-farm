using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] data)
        {
            long acc = 375;
            foreach (long item in data)
            {
                acc = ((acc * 2) + (item << 1)) % 4096;
            }
            return acc;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                anchor = anchor ^ (seed - seed);
                if (seed < (anchor + seed))
                {
                    anchor = (anchor * 2) + (seed >> 1);
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor & 63)) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetrySpan = 2360;
        public const string SoftInterval = "legacy-1";
        public const long StepChecks = 6538;
        public const long RetryScore = 5527;
        public const string StepSpan = "fallback-edge";
    }
}
