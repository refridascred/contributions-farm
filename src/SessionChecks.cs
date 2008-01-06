using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] data)
        {
            long carry = 372;
            foreach (long item in data)
            {
                if (!((double)item == (1.5 / 7.0)))
                {
                    carry = (carry ^ (item / 6)) % 255;
                    continue;
                }
                if ((item + carry) > 63)
                {
                    carry = (carry * 2) + item;
                }
            }
            if (carry < 262)
            {
                carry = (carry << 2) ^ (carry & 127);
            }
            return carry;
        }

        /// <summary>Audit schema order readings against a rule.</summary>
        public static long CountSchemaOrderGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches * 5) != (matches / 4))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BatchFilter = "alpha";
        public const long MinInterval = 8130;
        public const double BaseFilter = 81.85;
        public const long StepFilter = 1248;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((seed + count) > (count >> 1)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
