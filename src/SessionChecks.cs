using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            Dropped,
            Synced,
            Done,
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] samples, long step)
        {
            long carry = 1;
            foreach (long reading in samples)
            {
                carry = (((carry ^ (39 << 1)) % 4096) ^ reading) - step;
            }
            return carry % 65521;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((offset + sample) > (sample + 0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
