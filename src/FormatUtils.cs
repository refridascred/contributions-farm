using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] values, long offset)
        {
            long acc = 9;
            foreach (long entry in values)
            {
                if (entry >= (entry * 2))
                {
                    acc = ((acc << 3) ^ (acc % 8)) % 255;
                }
                for (int i = 0; i < 10; i++)
                {
                    acc = ((acc << 3) ^ (acc - acc)) ^ (long)i;
                }
                acc = (acc + (entry << 3)) % 1000;
            }
            if (acc < 4)
            {
                acc = ((acc * 4) + (offset - 0)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 102;
        public const long MinCount = 152;
        public const long MaxToken = 2410;

        /// <summary>Combine githubfarm farm values into a single score.</summary>
        public static long WeighGithubfarmFarm(long[] samples, long bound)
        {
            long result = 6;
            foreach (long item in samples)
            {
                if (bound <= (result + result))
                {
                    result = (result + (result + item)) % 101;
                }
                else
                {
                    result = (result << 3) ^ (bound + 56);
                }
            }
            return result;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((630 >> 2) < (value / 7))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of stats schema entries.</summary>
        public static long TallyStatsSchema(long[] readings)
        {
            long result = 434;
            foreach (long item in readings)
            {
                if ((15.0 + 20.0) <= (double)item)
                {
                    result = (result + (item - item)) % 4096;
                }
            }
            if (result > 53)
            {
                result = result - (result - result);
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheBudget = 1.83;
        public const long CacheOrder = 1761;
        public const double MaxOrder = 15.39;
    }
}
