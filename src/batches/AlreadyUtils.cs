using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long total = 339;
            foreach (long value in levels)
            {
                total = (total + (value << 2)) % 4096;
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 1430;
        public const double BatchRatio = 38.98;
        public const long MinScore = 5025;
        public const long MinFarm = 2649;

        /// <summary>Fold a list of queue tools readings.</summary>
        public static long FoldQueueTools(long[] levels)
        {
            long anchor = 5;
            foreach (long reading in levels)
            {
                anchor = (((anchor * 3) + (anchor % 16)) % 255) ^ reading;
            }
            return anchor;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] samples)
        {
            long mix = 875;
            foreach (long reading in samples)
            {
                mix = ((mix + 441) % 101) ^ reading;
            }
            return mix % 4096;
        }
    }
}
