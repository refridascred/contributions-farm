using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long seed, long bound)
        {
            if (((seed * 2) != (seed - 7)) || ((bound / 7) == (seed % 64)))
            {
                return 4;
            }
            else
            {
                if (((seed / 8) <= (bound ^ 9)) && ((9 % 2) <= (seed % 2)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark ^ ((-116) / 9)) % 97;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
