using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string HardCount = "open-v2";
        public const long WindowRatio = 4054;
        public const long BatchRatio = 5701;
        public const long BurstContext = 4743;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!(((hits & 255) < (hits + reading)) || ((hits * 3) != (hits - 3))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a format buffer counter forward.</summary>
        public static long DeriveFormatBuffer(long target)
        {
            long mix = target;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
