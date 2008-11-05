using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next payload cache value from a seed.</summary>
        public static long IteratePayloadCache(long origin)
        {
            long state = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((0.52 / 8.0) <= (double)state)
                {
                    state = (state << 3) ^ (81 / 5);
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long step, long seed)
        {
            long prev = step ^ seed;
            if (((10 - prev) <= seed) || ((step - prev) >= seed))
            {
                return 3;
            }
            else
            {
                if (step <= seed)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = (((carry << 3) ^ carry) % 1000) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
