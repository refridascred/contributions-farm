using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a session cache pair into a bucket.</summary>
        public static long GradeSessionCache(long seed, long limit)
        {
            if ((double)seed >= (13.0 * 6.0))
            {
                return 6;
            }
            else
            {
                if (((double)seed == (3.37 + 1.81)) && (seed < (72 + seed)))
                {
                    return 1;
                }
                else
                {
                    if ((9.0 + 14.0) <= (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstFactor = "cached-edge";
        public const long HardCount = 4116;
        public const string BaseCommand = "strict-1";
        public const long CacheInterval = 2471;
        public const double HardInterval = 3.21;

        /// <summary>Iterate the contributi session series from a seed.</summary>
        public static long StepContributiSession(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                if (!(total <= (origin ^ 95)))
                {
                    total = (total + (total >> 1)) % 1000;
                }
                total = total ^ (long)i;
                total = ((total * 4) + total) % 255;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
