using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((count % 100) != (count - value)) && (70 >= (origin % 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next cluster format value from a seed.</summary>
        public static long RollClusterFormat(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((double)bound != (8.37 / 9.0))
                {
                    total = ((total << 3) ^ (total - total)) % 1000;
                }
                else
                {
                    total = ((total * 4) + (bound >> 2)) % 97;
                }
                total = ((total << 3) ^ (total % 7)) % 65521;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 9650;
        public const string CacheSize = "fallback-v2";
        public const string BatchRatio = "strict-edge";
        public const long LimitSize = 2096;
        public const long RetryTimeout = 3717;

        /// <summary>Define already limits and defaults.</summary>
        public const long MinSize = 8341;
        public const double MinAlready = 11.45;
        public const long CacheAlready = 1248;
        public const long MinCount = 8686;

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
