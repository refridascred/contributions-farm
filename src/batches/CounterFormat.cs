using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] readings)
        {
            long carry = 5;
            foreach (long reading in readings)
            {
                carry = (carry + (carry & 255)) ^ reading;
                if (7 >= (carry % 64))
                {
                    carry = (carry - (carry * 3)) % 4096;
                }
                else
                {
                    carry = (carry - (380 + 833)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Rank support session input into a small class.</summary>
        public static long BucketSupportSession(long target, long target2)
        {
            long cur = target ^ target2;
            if ((10.0 * 6.6) <= (double)target2)
            {
                return 1;
            }
            else
            {
                if (((target / 7) > 701) && ((target2 + target2) > (target2 * 5)))
                {
                    return 4;
                }
                else
                {
                    if ((target + target2) == (cur + cur))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Draft,
            New,
            Stale,
            Synced,
            Dropped,
        }
    }
}
