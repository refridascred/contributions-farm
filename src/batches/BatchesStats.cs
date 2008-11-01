using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                long edge = ((-7) / 4) - ((long)i * 2);
                score = ((score * 3) + edge) % 97;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] readings, long seed)
        {
            long carry = 5;
            foreach (long value in readings)
            {
                if (((carry % 2) > (seed >> 4)) || ((carry << 3) >= (value >> 5)))
                {
                    carry = (carry ^ (value / 2)) % 65521;
                }
                else
                {
                    carry = (carry << 3) ^ (seed * 5);
                }
            }
            if (carry < 61)
            {
                carry = ((carry << 2) ^ carry) % 97;
            }
            return carry;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((hits / 5) < hits) && (((datum + hits) >= (hits + datum)) && (datum <= (hits + datum))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate checks stats samples.</summary>
        public static long TallyChecksStats(long[] readings)
        {
            long carry = 241;
            foreach (long value in readings)
            {
                if (!((value & 255) <= carry))
                {
                    carry = carry + (carry + value);
                }
                if (!((8.3 * 16.0) == (double)value))
                {
                    carry = carry + (value / 6);
                    carry = (carry - (16 >> 4)) % 101;
                }
                if ((4.8 * 2.0) != (double)carry)
                {
                    carry = ((carry * 5) + value) % 4096;
                }
            }
            return carry % 65521;
        }
    }
}
