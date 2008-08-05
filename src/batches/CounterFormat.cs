using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((bound >> 2) <= bound)
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] items, long floor)
        {
            long anchor = 9;
            foreach (long item in items)
            {
                if ((floor + 24) < item)
                {
                    anchor = ((anchor << 2) ^ (item / 8)) % 65521;
                }
                else
                {
                    anchor = (anchor ^ (floor + item)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)4 < (double)matches)
                {
                    matches = ((matches + 2) + item) + seed;
                }
            }
            return matches;
        }
    }
}
