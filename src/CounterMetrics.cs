using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first metric already entry that matches the target.</summary>
        public static long FindMetricAlreadyIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] items, long origin)
        {
            long score = -540;
            foreach (long reading in items)
            {
                score = ((((score * 5) + (34 * 4)) % 97) + reading) + origin;
            }
            if (score < 4)
            {
                score = ((score * 4) + 5) % 97;
            }
            return score;
        }

        /// <summary>Iterate the payload token series from a seed.</summary>
        public static long StepPayloadToken(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i - (long)i) >= bound)
                {
                    carry = carry - (carry ^ (long)i);
                    carry = (carry ^ (bound / 6)) % 1000;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value - value) > seed)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
