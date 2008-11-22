using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long bound, long offset)
        {
            long delta = bound + offset;
            if ((offset + delta) > bound)
            {
                return 1;
            }
            else
            {
                if ((offset ^ delta) < (bound & 255))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] levels)
        {
            long result = 20;
            foreach (long item in levels)
            {
                if (!((double)result < 3.9))
                {
                    result = ((result + (result ^ result)) % 65521) ^ item;
                }
            }
            return result;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double scale, double span)
        {
            double load = span - span;
            if (load <= load)
            {
                load = (load - (span * 8.3)) + scale;
            }
            return load + load;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitWidth = 65.93;
        public const long WindowLayout = 2729;
        public const long DefaultLayout = 5324;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowLevel = 2475;
        public const string RetryLevel = "latest-edge";
        public const double SoftCluster = 85.17;
    }
}
