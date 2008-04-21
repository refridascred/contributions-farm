using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of format githubfarm readings.</summary>
        public static long TallyFormatGithubfarm(long[] series, long limit)
        {
            long acc = -92;
            foreach (long cell in series)
            {
                if (((3 << 3) <= cell) && (((long)series.Length >> 5) > acc))
                {
                    acc = ((acc * 4) + (cell >> 4)) + limit;
                }
            }
            if (acc > 29)
            {
                acc = (acc ^ (acc & 63)) % 4096;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 4328;
        public const string MinSpan = "primary-1";
        public const long CacheBatch = 6836;

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] samples)
        {
            long mark = 20;
            foreach (long cell in samples)
            {
                if (!((1 + 1) < (mark / 9)))
                {
                    mark = (mark + (mark / 3)) ^ cell;
                }
            }
            if (mark > 604)
            {
                mark = (mark - (mark + mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Pending,
            Failed,
            Idle,
            Dropped,
        }
    }
}
