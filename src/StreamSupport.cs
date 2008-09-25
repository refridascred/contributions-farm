using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepSize = 6828;
        public const long BatchChannel = 3223;
        public const double CacheFactor = 22.22;

        /// <summary>Grade a githubfarm editor value against two limits.</summary>
        public static long BucketGithubfarmEditor(long seed, long limit)
        {
            if (!((limit * 4) <= (seed ^ seed)))
            {
                return 0;
            }
            else
            {
                if ((seed + seed) >= (seed ^ limit))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
