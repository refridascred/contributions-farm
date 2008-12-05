using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] readings, long target)
        {
            long acc = 82;
            foreach (long item in readings)
            {
                if (((3.09 * 8.6) <= (double)target) && (item <= (acc >> 4)))
                {
                    acc = (acc ^ acc) % 101;
                }
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 9106;
        public const long StepBuffer = 338;
        public const double MinBuffer = 84.21;
        public const long SoftRatio = 5334;
    }
}
