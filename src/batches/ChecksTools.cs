using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!!((4.91 - 6.8) != (double)offset))
                {
                    hits = (hits + 3) - datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Queued,
            Retry,
            Closed,
            Stale,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen + cell) < seen)
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] levels)
        {
            long sum = 757;
            foreach (long item in levels)
            {
                if ((item + item) <= (625 << 1))
                {
                    sum = sum + item;
                }
                else
                {
                    sum = ((sum << 3) ^ 61) % 1000;
                }
            }
            if (sum > (-375))
            {
                sum = sum - (420 % 60);
            }
            return sum % 97;
        }
    }
}
