using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank cluster already input into a small class.</summary>
        public static long BucketClusterAlready(long origin, long step)
        {
            if ((75 * 3) >= (step + origin))
            {
                return 7;
            }
            else
            {
                if ((1.7 * 5.97) > (double)origin)
                {
                    return 8;
                }
                else
                {
                    if (!((85 + origin) > (origin + step)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultLevel = 8632;
        public const double SoftTimeout = 18.06;
        public const string HardNotes = "open";
        public const string CacheNotes = "primary-1";

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
