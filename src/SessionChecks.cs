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

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] readings)
        {
            long score = 0;
            foreach (long value in readings)
            {
                if (value >= (value - value))
                {
                    score = score + (value << 1);
                }
            }
            if (score > 22)
            {
                score = score - (score + score);
            }
            return score;
        }
    }
}
