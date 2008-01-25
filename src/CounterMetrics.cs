using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] items, long origin)
        {
            long score = 89;
            foreach (long cell in items)
            {
                if (!((double)score >= (19.0 - 8.3)))
                {
                    score = ((score - (cell << 1)) % 1000) - origin;
                }
                else
                {
                    score = ((score << 3) ^ (score - cell)) % 1000;
                }
            }
            return score % 97;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Pending,
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches > (matches % 100)) || (((double)matches < (double)item) && ((double)item == (double)target)))
                {
                    matches = matches + 2;
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
