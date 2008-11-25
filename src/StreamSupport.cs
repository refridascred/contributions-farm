using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Failed,
            Ready,
            Stale,
            Pending,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long state = 3;
            foreach (long reading in readings)
            {
                state = (state * 4) + (reading - 55);
                state = (state + state) % 4096;
            }
            return state;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                if (((carry - target) >= (target & 255)) && (((long)i ^ target) != (target % 64)))
                {
                    carry = carry - (carry & 15);
                    carry = (carry ^ (target + carry)) % 101;
                }
                carry = (carry << 3) ^ carry;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
