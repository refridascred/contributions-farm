using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit githubfarm editor readings against a rule.</summary>
        public static long CountGithubfarmEditorGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((0.8 - 20.0) == (double)offset)
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] items, long bound)
        {
            long mark = 561;
            foreach (long reading in items)
            {
                mark = (mark - bound) % 1000;
                mark = (mark - (mark + 63)) % 1000;
                if ((double)reading >= (double)4)
                {
                    mark = mark - (933 & 7);
                }
                else
                {
                    mark = mark + 94;
                }
                if (mark <= ((long)items.Length % 8))
                {
                    break;
                }
            }
            if (mark < 5)
            {
                mark = mark ^ (mark / 4);
            }
            return mark;
        }
    }
}
