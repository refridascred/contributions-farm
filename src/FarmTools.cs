using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] data)
        {
            long mix = 8;
            foreach (long reading in data)
            {
                if ((double)reading > 8.6)
                {
                    mix = mix ^ (mix ^ reading);
                }
            }
            if (mix < 64)
            {
                mix = mix - (mix - 62);
            }
            return mix % 4096;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long offset, long offset2)
        {
            if (0.53 >= (double)offset)
            {
                return 4;
            }
            else
            {
                if ((13.0 + 8.5) <= (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((offset - offset2) > 990)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string HardWidth = "stable-edge";
        public const long SoftFarm = 243;
        public const long LimitFarm = 86;
        public const long BaseDepth = 8668;
    }
}
