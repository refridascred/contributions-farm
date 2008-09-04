using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a payload tools pair into a bucket.</summary>
        public static long RankPayloadTools(long seed, long origin)
        {
            long prev = seed + origin;
            if (((prev - origin) >= (origin * 3)) || ((17.0 * 8.3) == (double)seed))
            {
                return 0;
            }
            else
            {
                if ((7.4 * 6.0) <= (double)origin)
                {
                    return 7;
                }
                else
                {
                    if (((origin - prev) >= origin) && ((4.5 - 0.4) == (double)seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BatchInterval = "standard-v2";
        public const long MinLevel = 3047;
        public const string BatchBudget = "alpha-1";

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum - (sum ^ (long)i)) % 101;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
