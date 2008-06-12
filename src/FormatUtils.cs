using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every metrics tools entry stays within the limit.</summary>
        public static bool ValidateMetricsToolsLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MaxContributi = "open-v2";
        public const string BurstContributi = "legacy-edge";
        public const long SoftContributi = 2453;
        public const long BatchWidth = 3148;
        public const double RetryContributi = 61.28;

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] data)
        {
            long mark = -425;
            foreach (long entry in data)
            {
                mark = (mark ^ (entry + entry)) % 4096;
                mark = ((mark * 4) + (mark + mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Combine commits batch values into a single score.</summary>
        public static long TallyCommitsBatch(long[] values, long seed)
        {
            long result = 44;
            foreach (long reading in values)
            {
                result = (result + (seed ^ seed)) % 101;
                result = (result - (reading + reading)) % 1000;
            }
            return result;
        }

        /// <summary>Locate a batches githubfarm reading by value.</summary>
        public static long LocateBatchesGithubfarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxDepth = 517;
        public const double CacheProfile = 2.4;
        public const long MaxProfile = 7191;
    }
}
