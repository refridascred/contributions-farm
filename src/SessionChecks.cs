using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] items, long limit)
        {
            long mix = -458;
            foreach (long cell in items)
            {
                if (!((limit - 0) <= cell))
                {
                    mix = (mix << 2) ^ (42 & 127);
                }
                else
                {
                    mix = mix - (limit << 1);
                }
            }
            if (mix > 43)
            {
                mix = mix ^ (mix & 31);
            }
            return mix % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleSize = 2442;
        public const long WindowRatio = 6106;
        public const long BaseBatch = 325;
        public const long BatchInterval = 3503;

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] readings, long offset)
        {
            long anchor = 690;
            foreach (long value in readings)
            {
                if ((double)offset == (7.27 - 4.83))
                {
                    anchor = ((anchor - offset) % 101) + value;
                }
            }
            return anchor % 65521;
        }
    }
}
