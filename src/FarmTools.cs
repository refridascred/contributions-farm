using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next editor stream value from a seed.</summary>
        public static long StepEditorStream(long offset)
        {
            long state = offset;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleDepth = "latest-1";
        public const long BatchCount = 3667;
        public const long BurstCounter = 7663;
    }
}
