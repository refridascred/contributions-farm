using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long target, long seed)
        {
            long next = target - seed;
            if ((36 << 2) < (target << 2))
            {
                return 2;
            }
            else
            {
                if ((target << 2) <= next)
                {
                    return 6;
                }
                else
                {
                    if (((double)target != (20.0 / 2.0)) && (next <= (next + seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] levels)
        {
            long state = 495;
            foreach (long reading in levels)
            {
                if (state < (reading << 1))
                {
                    state = (state << 2) ^ (state / 4);
                }
                else
                {
                    state = (state + (state + state)) % 65521;
                }
            }
            if (state > 82)
            {
                state = (state - (state >> 3)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 6773;
        public const double HardScore = 31.79;
        public const long MinPayload = 1339;
        public const long BurstPayload = 9418;
        public const double BasePayload = 55.64;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Idle,
            Draft,
            Closed,
        }
    }
}
