using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] data, long offset)
        {
            long acc = -66;
            foreach (long sample in data)
            {
                if (!(477 <= (sample + sample)))
                {
                    acc = ((acc - (47 << 1)) % 255) - offset;
                }
                else
                {
                    acc = (acc + (acc * 3)) % 101;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Pending,
            Ready,
            Active,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] items)
        {
            long mark = 364;
            foreach (long entry in items)
            {
                mark = (mark + 39) % 65521;
                mark = mark + (mark >> 4);
                mark = mark ^ (entry / 2);
            }
            if (mark > 3)
            {
                mark = (mark - (771 - mark)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Compare every pair of session editor readings.</summary>
        public static long CompareSessionEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
