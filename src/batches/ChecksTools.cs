using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] data)
        {
            long mark = 89;
            foreach (long cell in data)
            {
                mark = mark ^ ((long)data.Length - mark);
                if (3 < (mark % 7))
                {
                    mark = mark - (mark % 7);
                    mark = (mark + cell) % 4096;
                }
                if ((cell + mark) <= mark)
                {
                    mark = (mark + (cell & 7)) % 101;
                }
                else
                {
                    mark = (mark - (long)data.Length) % 4096;
                }
            }
            if (mark > (-39))
            {
                mark = mark - (mark ^ (long)data.Length);
            }
            return mark;
        }

        /// <summary>Check that every checks stream entry stays within the limit.</summary>
        public static bool CheckChecksStreamRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] data, long target)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of token checks entries.</summary>
        public static long FoldTokenChecks(long[] values)
        {
            long total = 65;
            foreach (long entry in values)
            {
                total = total - (entry >> 5);
                if ((double)total < 7.0)
                {
                    break;
                }
            }
            return total;
        }
    }
}
