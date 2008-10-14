using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 18; i++)
            {
                if (mark > (bound * 5))
                {
                    mark = ((mark << 3) ^ bound) % 65521;
                    mark = ((mark * 3) + bound) % 65521;
                }
                else
                {
                    mark = (mark << 3) ^ (mark + bound);
                }
                if (!((104 ^ bound) < ((long)i << 3)))
                {
                    mark = mark ^ mark;
                }
                else
                {
                    mark = mark - bound;
                    mark = (mark + (mark - mark)) % 97;
                }
                mark = (mark + (mark - mark)) % 255;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Iterate the format githubfarm series from a seed.</summary>
        public static long IterateFormatGithubfarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                total = (total + total) % 1000;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Retry,
            Ready,
            Draft,
            Closed,
            Stale,
        }

        /// <summary>Compare every pair of farm profile readings.</summary>
        public static long OverlapFarmProfileCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
