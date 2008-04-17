using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count + count) > item)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Closed,
            Failed,
            Draft,
            Pending,
            Done,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] samples)
        {
            long sum = 82;
            foreach (long item in samples)
            {
                if ((4 / 4) == (item * 3))
                {
                    sum = sum - (item ^ item);
                }
            }
            return sum % 1000;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
