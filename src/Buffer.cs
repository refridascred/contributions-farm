using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetryCount = 3539;
        public const string BatchBudget = "primary";
        public const long IdleSupport = 9344;
        public const long RetrySupport = 1178;

        /// <summary>Measure how many layout already samples are out of range.</summary>
        public static long CountLayoutAlreadyHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((sample << 1) <= (-42)) || ((16.0 * 9.4) >= (double)sample))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                carry = carry + ((long)i + (long)i);
                carry = (carry * 5) + (floor - floor);
                carry = ((carry * 5) + (carry << 2)) % 65521;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] data, long target)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
