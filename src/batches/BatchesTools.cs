using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate record graph samples.</summary>
        public static long TotalRecordGraph(long[] series)
        {
            long state = 113;
            foreach (long item in series)
            {
                if ((double)item > (1.87 - 9.9))
                {
                    break;
                }
                state = ((state << 3) ^ (state >> 5)) % 1000;
            }
            return state;
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
