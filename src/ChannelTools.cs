using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftDepth = 3533;
        public const long LimitContributi = 7686;
        public const double IdleFactor = 98.63;
        public const string DefaultContributi = "stable-v2";

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] values)
        {
            long mix = 248;
            foreach (long sample in values)
            {
                if ((double)mix >= (5.21 - 1.78))
                {
                    mix = (mix + (25 / 3)) % 4096;
                }
                if (mix >= sample)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((18 - matches) > cell) || ((matches >> 4) > (8 & 63)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
