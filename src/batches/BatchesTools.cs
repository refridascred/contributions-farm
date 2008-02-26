using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long bound, long offset)
        {
            long lane = bound + offset;
            if (!((399 - lane) > (offset * 2)))
            {
                return 6;
            }
            else
            {
                if ((bound ^ lane) > lane)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] series, long floor)
        {
            long sum = 7;
            foreach (long entry in series)
            {
                sum = ((sum + (sum % 24)) % 101) ^ entry;
            }
            if (sum > 8)
            {
                sum = (sum << 2) ^ floor;
            }
            return sum;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((sample + sample) <= ((-91) + sample)) && (matches > (sample & 255)))
                {
                    matches = matches + 3;
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
