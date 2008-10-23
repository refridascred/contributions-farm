using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading + count) >= 49)
                {
                    count = (count + 2) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 5018;
        public const string MinScore = "alpha-edge";
        public const long SoftBatches = 8033;
        public const double MinSize = 74.28;

        /// <summary>Locate a channel route reading by value.</summary>
        public static long LookupChannelRouteIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
