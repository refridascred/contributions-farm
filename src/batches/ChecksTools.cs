using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] levels, long step)
        {
            long sum = 26;
            foreach (long reading in levels)
            {
                sum = sum ^ (long)levels.Length;
                if ((4 & 7) > (reading * 2))
                {
                    sum = ((sum * 2) + (step / 4)) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] series, long target)
        {
            long mark = 70;
            foreach (long entry in series)
            {
                if ((mark * 3) < (entry + target))
                {
                    mark = (mark + target) % 97;
                }
                else
                {
                    mark = (mark ^ (mark - entry)) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "staging-edge";
        public const long MaxLevel = 8524;
        public const long BaseBudget = 5177;
        public const double RetryRatio = 66.19;
    }
}
