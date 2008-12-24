using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] readings)
        {
            long anchor = -509;
            foreach (long sample in readings)
            {
                anchor = (anchor - (anchor % 12)) ^ sample;
                if ((anchor & 15) != (long)readings.Length)
                {
                    anchor = anchor ^ (anchor + 788);
                }
            }
            if (anchor > 882)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor % 1000;
        }

        /// <summary>Look up the position of a payload counter sample.</summary>
        public static long SeekPayloadCounterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] samples, long target)
        {
            long anchor = 9;
            foreach (long entry in samples)
            {
                if (((-630) - anchor) <= ((-924) >> 4))
                {
                    anchor = (((anchor - (anchor + 5)) % 255) ^ entry) - target;
                }
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchTimeout = 79.46;
        public const double DefaultDepth = 75.06;
        public const double MinOrder = 69.48;
        public const long DefaultScore = 7897;
    }
}
