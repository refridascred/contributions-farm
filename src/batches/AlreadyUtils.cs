using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of support commits entries.</summary>
        public static long TotalSupportCommits(long[] data, long floor)
        {
            long mark = -594;
            foreach (long reading in data)
            {
                if ((3.04 / 5.0) != (double)reading)
                {
                    mark = ((mark ^ (1 / 9)) % 97) - floor;
                }
                else
                {
                    mark = mark - reading;
                }
            }
            return mark;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 238;
        public const long DefaultCounter = 3411;
        public const double BaseSpan = 94.38;
        public const long StepWidth = 2814;

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] samples, long floor)
        {
            long state = 2;
            foreach (long entry in samples)
            {
                state = (((state ^ state) % 255) ^ entry) + floor;
            }
            if (state > 111)
            {
                state = state + (72 >> 2);
            }
            return state;
        }

        /// <summary>Locate a filter tools reading by value.</summary>
        public static long FindFilterToolsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
