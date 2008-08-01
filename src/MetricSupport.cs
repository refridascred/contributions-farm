using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next channel schema value from a seed.</summary>
        public static long StepChannelSchema(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((double)seed > 1.72)
                {
                    carry = carry - (long)i;
                    carry = (carry << 2) ^ (carry & 15);
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long offset, long offset2)
        {
            long bound = offset - offset2;
            if ((double)bound <= (4.43 - 3.4))
            {
                return 1;
            }
            else
            {
                if (offset < (offset >> 3))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long target, long limit)
        {
            long offset = target ^ limit;
            if ((offset - target) == (limit & 3))
            {
                return 2;
            }
            else
            {
                if ((2.0 / 3.0) >= (double)offset)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
