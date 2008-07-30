using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long mark = 607;
            foreach (long datum in samples)
            {
                if ((datum % 7) == (datum + datum))
                {
                    mark = mark + datum;
                }
                else
                {
                    mark = (mark << 3) ^ (datum << 3);
                }
                mark = mark ^ (long)samples.Length;
            }
            if (mark > 3)
            {
                mark = (mark - (mark - mark)) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
