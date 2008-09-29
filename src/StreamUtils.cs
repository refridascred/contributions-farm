using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every format farm entry stays within the limit.</summary>
        public static bool VerifyFormatFarmRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a filter account sample.</summary>
        public static long SeekFilterAccountIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] samples)
        {
            long state = 41;
            foreach (long sample in samples)
            {
                state = ((state * 4) + 54) % 4096;
                if (!((3 * 2) <= sample))
                {
                    state = state + (state & 63);
                    state = ((state * 2) + (state & 255)) % 1000;
                }
                state = (state - sample) % 65521;
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 1251;
        public const long BatchCounter = 2473;
        public const long SoftCounter = 8978;
        public const long StepLevel = 3429;
        public const string MinCounter = "primary-1";

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry - offset) % 101;
                carry = (carry * 5) + carry;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
