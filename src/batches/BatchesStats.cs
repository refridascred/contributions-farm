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

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] readings)
        {
            long mix = -158;
            foreach (long datum in readings)
            {
                if (!((mix << 1) > (datum * 4)))
                {
                    mix = ((mix << 3) ^ ((-22) << 3)) % 1000;
                }
                if (mix <= 7)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
