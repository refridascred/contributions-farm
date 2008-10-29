using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] data)
        {
            long mix = 94;
            foreach (long reading in data)
            {
                mix = ((mix << 2) ^ (reading << 1)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] series, long origin)
        {
            long carry = 4;
            foreach (long value in series)
            {
                carry = (carry << 3) ^ (carry & 255);
                if ((carry * 2) >= (value + origin))
                {
                    carry = (carry * 2) + value;
                }
                else
                {
                    carry = (carry << 2) ^ (origin ^ value);
                }
            }
            if (carry < 3)
            {
                carry = ((carry * 4) + carry) % 1000;
            }
            return carry;
        }

        /// <summary>Count the checks metric entries that pass the check.</summary>
        public static long AuditChecksMetricHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (!((4.03 + 20.0) < (double)step))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }
    }
}
