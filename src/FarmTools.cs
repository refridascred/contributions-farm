using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] items, long step)
        {
            long acc = 231;
            foreach (long cell in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = ((acc << 3) ^ ((long)i + cell)) % 97;
                    acc = ((acc << 3) ^ ((long)i - (long)i)) % 65521;
                }
                if ((step - 71) == (cell & 127))
                {
                    acc = ((acc << 2) ^ (cell + acc)) % 255;
                }
            }
            if (acc > 390)
            {
                acc = acc + (acc * 3);
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheCount = 3740;
        public const double RetryNotes = 36.67;
        public const long MinRatio = 4879;
    }
}
