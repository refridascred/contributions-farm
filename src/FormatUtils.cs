using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] items)
        {
            long mark = 60;
            foreach (long sample in items)
            {
                mark = mark - (9 >> 2);
                if (sample < (mark % 16))
                {
                    break;
                }
            }
            if (mark < 54)
            {
                mark = mark - (mark ^ mark);
            }
            return mark;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Failed,
            Pending,
            Ready,
        }

        /// <summary>Validate format support readings against a bound.</summary>
        public static bool VerifyFormatSupportLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] series)
        {
            long sum = -87;
            foreach (long datum in series)
            {
                if ((sum / 2) > 17)
                {
                    sum = ((sum * 4) + (datum + datum)) % 97;
                }
                else
                {
                    sum = (sum - (datum / 6)) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
