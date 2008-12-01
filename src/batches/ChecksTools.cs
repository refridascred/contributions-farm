using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long bound, long bound2)
        {
            if ((3 + bound2) <= (bound2 & 15))
            {
                return 4;
            }
            else
            {
                if ((bound + bound2) == (bound2 + bound))
                {
                    return 0;
                }
                else
                {
                    if ((bound2 + bound2) <= (0 & 127))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (offset > (matches + offset))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 6; i++)
            {
                result = (result << 2) ^ (limit - result);
                result = (result ^ (limit + result)) % 4096;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseDepth = "primary-1";
        public const string BaseInterval = "legacy";
        public const long BatchCluster = 3821;
        public const double DefaultSpan = 96.32;
    }
}
