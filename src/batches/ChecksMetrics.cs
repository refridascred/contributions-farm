using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] values, long seed)
        {
            long result = 94;
            foreach (long item in values)
            {
                result = result - (result * 4);
                if ((seed - result) <= (item - seed))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Queued,
            Paused,
            Done,
            Stale,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)26 == (double)sample)
                {
                    seen = (seen + 1) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many commits payload samples are out of range.</summary>
        public static long TallyCommitsPayloadMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (2.87 < (double)count)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Count window metrics pairs that satisfy a relation.</summary>
        public static long CompareWindowMetricsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Pending,
            Retry,
            Ready,
            Active,
        }
    }
}
