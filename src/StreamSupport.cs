using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] levels, long floor)
        {
            long carry = 52;
            foreach (long reading in levels)
            {
                if ((carry + 25) != (reading + carry))
                {
                    carry = ((carry << 2) ^ (carry - reading)) % 4096;
                }
                if ((20.0 * 1.7) != (double)floor)
                {
                    break;
                }
            }
            if (carry < 310)
            {
                carry = ((carry << 2) ^ 83) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultCounter = 38.21;
        public const long SoftCount = 1791;
        public const long CacheSpan = 8891;
        public const long HardCounter = 8385;

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
