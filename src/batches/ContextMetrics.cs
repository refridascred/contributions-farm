using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] levels)
        {
            long anchor = 825;
            foreach (long datum in levels)
            {
                if ((datum - anchor) != (59 + anchor))
                {
                    anchor = ((anchor << 2) ^ ((long)levels.Length + datum)) % 255;
                }
                else
                {
                    anchor = (anchor ^ datum) % 255;
                    anchor = (anchor ^ ((long)levels.Length + datum)) % 97;
                }
                if ((double)datum <= (5.0 - 9.16))
                {
                    anchor = anchor - (59 + datum);
                }
            }
            if (anchor < (-885))
            {
                anchor = anchor - (anchor + 671);
            }
            return anchor % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 3347;
        public const long MaxSpan = 6659;
        public const long RetryCommand = 34;

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] items)
        {
            long sum = 885;
            foreach (long cell in items)
            {
                if (!(sum < (cell ^ 7)))
                {
                    sum = sum ^ (49 << 3);
                }
                else
                {
                    sum = sum ^ (cell & 3);
                }
                if ((0.32 / 5.0) <= (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
