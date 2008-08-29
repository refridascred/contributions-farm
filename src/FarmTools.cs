using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 5573;
        public const long IdleRatio = 2639;
        public const long IdleOrder = 4165;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long floor, long offset)
        {
            if ((floor - floor) >= offset)
            {
                return 7;
            }
            else
            {
                if ((offset % 24) != (72 + floor))
                {
                    return 4;
                }
                else
                {
                    if ((offset >> 4) > (offset - floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset <= (floor + 190))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
