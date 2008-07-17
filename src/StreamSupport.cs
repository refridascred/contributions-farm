using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                if ((target >> 4) <= (498 << 2))
                {
                    state = (state + target) % 255;
                    continue;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] levels, long seed)
        {
            long carry = 405;
            foreach (long reading in levels)
            {
                if ((double)carry <= (6.6 * 7.3))
                {
                    carry = carry - reading;
                }
                if (!((double)seed < (17.0 / 2.0)))
                {
                    carry = carry - (531 >> 1);
                }
            }
            if (carry > 5)
            {
                carry = carry - (carry * 5);
            }
            return carry;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Pending,
            Paused,
            Queued,
            Closed,
            Draft,
        }
    }
}
