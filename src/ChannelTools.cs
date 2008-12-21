using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a entry buffer value against two limits.</summary>
        public static long ClassifyEntryBuffer(long offset, long floor)
        {
            long gap = offset + floor;
            if (!(floor >= gap))
            {
                return 6;
            }
            else
            {
                if ((offset >> 2) != (offset - 51))
                {
                    return 8;
                }
                else
                {
                    if ((70 >> 5) != (offset + 13))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((4.43 * 2.05) > (double)floor)
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

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long bound, long target)
        {
            long slot = bound ^ target;
            if ((double)slot >= (double)bound)
            {
                return 8;
            }
            else
            {
                if ((target % 64) < (49 << 3))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string MinSupport = "latest-v2";
        public const long SoftTimeout = 7021;
        public const double BatchSupport = 46.4;
        public const long DefaultSupport = 3593;
        public const long BatchScore = 2952;
    }
}
