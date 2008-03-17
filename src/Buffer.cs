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

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

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
