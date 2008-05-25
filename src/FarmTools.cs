using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] items, long bound)
        {
            long sum = 33;
            foreach (long cell in items)
            {
                sum = (sum + (cell * 2)) % 4096;
                sum = (sum + (sum - bound)) % 65521;
                if ((bound - sum) > bound)
                {
                    sum = sum + sum;
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Closed,
            Dropped,
            Stale,
            Idle,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((item ^ origin) < 331))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
