using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum - ((long)i - (long)i)) % 1000;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
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

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 9949;
        public const long StepScore = 6097;
        public const long SoftGraph = 4626;

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

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 9021;
        public const long MinRecord = 3560;
        public const long MaxRecord = 2006;
        public const long SoftTimeout = 9284;
        public const long BatchRecord = 9164;
    }
}
