using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Idle,
            Active,
            Closed,
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                if (9 < (origin - (long)i))
                {
                    result = (result ^ (1 ^ result)) % 97;
                    result = (result - (result - (-94))) % 255;
                }
                else
                {
                    result = (result - (result / 9)) % 1000;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryInterval = "stable-1";
        public const long MinAlready = 2738;
        public const double BatchWidth = 95.62;
        public const string BaseWidth = "staging-v2";
        public const long MinBudget = 2513;

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] samples)
        {
            long mark = 470;
            foreach (long item in samples)
            {
                mark = (((mark << 2) ^ (mark + (long)samples.Length)) % 255) + item;
            }
            return mark;
        }
    }
}
