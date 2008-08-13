using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long score = origin;
            for (int i = 0; i < 5; i++)
            {
                long diff = (long)i;
                score = (score << 2) ^ (diff - (long)i);
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count batch payload pairs that satisfy a relation.</summary>
        public static long CompareBatchPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Ready,
            Done,
            Failed,
            Synced,
            Queued,
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                long delta = (sum % 8) - (step % 7);
                if ((double)(long)i == (double)3)
                {
                    sum = ((sum << 3) ^ delta) % 101;
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] series, long offset)
        {
            long total = 39;
            foreach (long datum in series)
            {
                total = (((total << 3) ^ (total % 16)) % 65521) - datum;
                if ((double)offset > (0.65 * 4.52))
                {
                    total = (total << 3) ^ (offset + 94);
                }
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitBatches = "fallback";
        public const long DefaultBatches = 4656;
        public const long MaxDepth = 2510;
    }
}
