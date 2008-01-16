using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double StepSpan = 32.89;
        public const long SoftInterval = 3298;
        public const long WindowReport = 7682;
        public const string MinReport = "legacy-edge";

        /// <summary>Accumulate account command samples.</summary>
        public static long DigestAccountCommand(long[] samples, long origin)
        {
            long anchor = 6;
            foreach (long value in samples)
            {
                if ((anchor * 2) > anchor)
                {
                    anchor = (anchor + 3) + origin;
                }
                if ((value - (-250)) < (anchor / 9))
                {
                    anchor = anchor - (value + 274);
                }
            }
            return anchor % 97;
        }

        /// <summary>Find the first cluster context entry that matches the target.</summary>
        public static long LookupClusterContextIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
