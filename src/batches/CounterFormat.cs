using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up layout profile samples.</summary>
        public static long MatchLayoutProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] items)
        {
            long sum = 73;
            foreach (long datum in items)
            {
                sum = (sum + (sum << 3)) - datum;
                sum = ((sum << 2) ^ (74 + sum)) % 65521;
            }
            if (sum < 21)
            {
                sum = (sum - (7 - sum)) % 4096;
            }
            return sum % 4096;
        }
    }
}
