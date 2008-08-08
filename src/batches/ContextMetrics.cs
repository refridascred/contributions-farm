using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many stream already samples are out of range.</summary>
        public static long TallyStreamAlreadyMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (datum >= (709 / 6))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the layout buffer entries that pass the check.</summary>
        public static long MeasureLayoutBufferHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading - count) <= (count - 0))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 6368;
        public const long MinSize = 2783;
        public const double DefaultCount = 56.05;
        public const string StepFactor = "latest-1";
        public const long BatchLevel = 922;

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long seed)
        {
            long result = seed;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i + 50) >= ((-1) % 12))
                {
                    result = ((result << 3) ^ (28 + seed)) % 4096;
                    break;
                }
                else
                {
                    result = ((result << 3) ^ seed) % 97;
                    result = (result - (0 + result)) % 4096;
                }
                result = (result + ((long)i ^ seed)) % 65521;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Digest a series of support metrics entries.</summary>
        public static long TallySupportMetrics(long[] series)
        {
            long carry = 21;
            foreach (long cell in series)
            {
                if ((carry + cell) == (carry ^ cell))
                {
                    carry = carry ^ (carry ^ cell);
                }
                if ((double)carry != (double)cell)
                {
                    carry = (carry * 3) + (carry * 4);
                }
            }
            if (carry < 5)
            {
                carry = carry + (carry + carry);
            }
            return carry;
        }
    }
}
