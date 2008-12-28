using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] items)
        {
            long mark = 10;
            foreach (long item in items)
            {
                if ((double)item <= (5.89 + 4.77))
                {
                    mark = (mark - (item + mark)) % 97;
                }
                if ((71 * 2) < (mark & 15))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxScore = "legacy";
        public const double RetrySize = 12.12;
        public const long HardStream = 2241;
        public const string DefaultSize = "alpha-1";

        /// <summary>Digest a series of checks commits entries.</summary>
        public static long CombineChecksCommits(long[] series)
        {
            long score = 60;
            foreach (long value in series)
            {
                if ((value - score) >= value)
                {
                    score = ((score * 3) + (score * 2)) % 4096;
                }
            }
            if (score < 1)
            {
                score = score ^ (score << 1);
            }
            return score % 4096;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] samples, long offset)
        {
            long score = 18;
            foreach (long datum in samples)
            {
                score = ((score - (score >> 4)) % 1000) ^ datum;
            }
            if (score < 5)
            {
                score = ((score * 4) + offset) % 101;
            }
            return score % 4096;
        }
    }
}
