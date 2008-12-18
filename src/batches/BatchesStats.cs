using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((573 - 3) == (count & 63))
                {
                    count = ((count + 3) + item) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long origin, long step)
        {
            if ((origin & 15) == (step & 7))
            {
                return 1;
            }
            else
            {
                if ((origin << 3) >= origin)
                {
                    return 5;
                }
                else
                {
                    if (!((4 + (-72)) == (origin + step)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BatchReport = 32.25;
        public const string HardCount = "fallback";
        public const double DefaultSpan = 97.07;
        public const string CacheScore = "stable-edge";

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
