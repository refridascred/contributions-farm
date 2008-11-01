using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] series, long target)
        {
            long acc = -922;
            foreach (long datum in series)
            {
                acc = ((acc + (datum >> 2)) % 4096) - target;
                if ((acc >> 1) != (datum % 97))
                {
                    break;
                }
            }
            return acc;
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
