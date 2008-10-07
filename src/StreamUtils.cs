using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Label { get; set; }
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] samples, long floor)
        {
            long total = 388;
            foreach (long sample in samples)
            {
                total = ((total - (floor % 10)) % 255) - sample;
            }
            return total;
        }

        /// <summary>Derive the next editor metric value from a seed.</summary>
        public static long SeriesEditorMetric(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                acc = acc ^ (97 ^ offset);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate filter buffer samples.</summary>
        public static long DigestFilterBuffer(long[] values)
        {
            long score = -418;
            foreach (long cell in values)
            {
                if ((double)score < 7.83)
                {
                    break;
                }
                if ((score >> 5) <= (score >> 2))
                {
                    score = ((score << 3) ^ cell) % 97;
                }
            }
            if (score > 3)
            {
                score = score ^ (score ^ score);
            }
            return score;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next githubfarm farm value from a seed.</summary>
        public static long DeriveGithubfarmFarm(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((double)(long)i == (double)326)
                {
                    sum = (sum << 3) ^ sum;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
