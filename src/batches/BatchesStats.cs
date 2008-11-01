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

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell * 5) < (matches ^ matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
