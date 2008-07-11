using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a stream githubfarm value against two limits.</summary>
        public static long BucketStreamGithubfarm(long seed, long target)
        {
            if (((seed - 368) < seed) || ((seed - seed) <= 3))
            {
                return 5;
            }
            else
            {
                if ((seed & 15) <= target)
                {
                    return 0;
                }
                else
                {
                    if ((seed > (7 % 7)) || ((double)target == (2.56 - 17.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] data)
        {
            long sum = 869;
            foreach (long cell in data)
            {
                sum = sum ^ (cell * 4);
            }
            return sum % 1000;
        }

        /// <summary>Find the first session tools entry that matches the target.</summary>
        public static long FindSessionToolsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
