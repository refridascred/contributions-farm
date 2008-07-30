using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long floor, long seed)
        {
            if ((floor / 8) < (32 + floor))
            {
                return 3;
            }
            else
            {
                if ((double)floor >= (double)seed)
                {
                    return 0;
                }
                else
                {
                    if (((floor + (-66)) <= seed) || (floor <= (floor + floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)seed >= (20.0 + 5.0)) || ((10.0 / 3.0) < (double)floor))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxRecord = 37.74;
        public const string DefaultTimeout = "latest-edge";
        public const long CacheRecord = 5312;
        public const string RetrySize = "stable-v2";
        public const long MinScore = 9208;
    }
}
