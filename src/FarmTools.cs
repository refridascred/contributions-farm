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

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 4723;
        public const long HardRecord = 6483;
        public const long BurstRecord = 1743;
        public const long MinRecord = 4331;
        public const long StepRecord = 841;

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
