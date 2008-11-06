using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm buffer samples.</summary>
        public static long FoldGithubfarmBuffer(long[] samples)
        {
            long mix = -820;
            foreach (long entry in samples)
            {
                mix = ((mix * 4) + (mix << 1)) - entry;
            }
            return mix;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long floor, long seed)
        {
            if ((seed << 1) > 4)
            {
                return 3;
            }
            else
            {
                if ((seed - seed) > floor)
                {
                    return 7;
                }
                else
                {
                    if ((seed > 68) || ((230 % 7) > floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
