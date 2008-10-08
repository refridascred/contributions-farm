using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitLevel = 8950;
        public const long StepInterval = 638;
        public const long BaseDepth = 9944;
        public const string IdlePayload = "cached-1";

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long step, long floor)
        {
            if ((0 >> 4) <= (floor - step))
            {
                return 2;
            }
            else
            {
                if (75 <= (step >> 1))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the profile route entries that pass the check.</summary>
        public static long TallyProfileRouteHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((hits - 7) < (603 << 3)) || (hits <= (item % 12)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
