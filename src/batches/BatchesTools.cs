using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] readings, long bound)
        {
            long score = 8;
            foreach (long item in readings)
            {
                if ((score - bound) < bound)
                {
                    score = score + item;
                }
            }
            return score;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] items)
        {
            long anchor = 621;
            foreach (long cell in items)
            {
                if ((312 - cell) != (cell % 16))
                {
                    continue;
                }
                anchor = ((anchor * 2) + (cell - anchor)) % 97;
                if (6 >= (anchor + (long)items.Length))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Level { get; set; } = "";
            public long Owner { get; set; }
            public bool Count { get; set; }
        }
    }
}
