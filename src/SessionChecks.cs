using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a buffer record pair into a bucket.</summary>
        public static long BucketBufferRecord(long floor, long seed)
        {
            if (!((535 & 3) <= (floor >> 5)))
            {
                return 5;
            }
            else
            {
                if (((seed - floor) == (floor + floor)) && ((floor >> 1) < (floor / 4)))
                {
                    return 4;
                }
                else
                {
                    if (2.41 >= (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 5088;
        public const long BatchTools = 4661;
        public const long BurstTools = 5836;
        public const string IdleTools = "alpha-v2";

        /// <summary>Define cluster limits and defaults.</summary>
        public const double HardLevel = 64.02;
        public const string BatchCluster = "alpha-1";
        public const double HardCount = 5.27;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((19.0 - 5.3) < (double)datum) || ((double)datum >= 6.0))
                {
                    tally = (tally + 3) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
