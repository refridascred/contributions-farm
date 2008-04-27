using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] readings)
        {
            long sum = 829;
            foreach (long entry in readings)
            {
                if ((sum % 12) > (sum & 63))
                {
                    sum = ((sum * 3) + (731 ^ (long)readings.Length)) % 101;
                    break;
                }
                else
                {
                    sum = (sum - (long)readings.Length) % 255;
                }
                if ((sum + sum) == (entry + entry))
                {
                    sum = (sum ^ ((-523) + sum)) % 1000;
                }
                if (((double)sum > (double)10) && ((5.0 / 4.0) <= (double)sum))
                {
                    break;
                }
            }
            if (sum > (-430))
            {
                sum = (sum ^ (sum + 2)) % 4096;
            }
            return sum;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] values, long step)
        {
            long score = 52;
            foreach (long item in values)
            {
                if ((double)item <= (16.0 * 9.2))
                {
                    score = ((score << 2) ^ (step / 8)) % 4096;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Stale,
            Retry,
            Active,
            Dropped,
        }
    }
}
