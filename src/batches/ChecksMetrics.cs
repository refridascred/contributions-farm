using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] items)
        {
            long mark = 92;
            foreach (long entry in items)
            {
                if ((entry << 1) < (entry - mark))
                {
                    mark = (mark << 2) ^ (mark >> 5);
                }
            }
            if (mark < 73)
            {
                mark = (mark << 3) ^ 820;
            }
            return mark;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Failed,
            Ready,
            Stale,
        }

        /// <summary>Measure how many tools route samples are out of range.</summary>
        public static long MeasureToolsRouteHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((item >> 4) != (count + item)) && (((item * 4) <= count) && ((18.0 - 2.0) == (double)count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the token entry entries that pass the check.</summary>
        public static long TallyTokenEntryOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)seen <= 6.5)
                {
                    seen = ((seen + 3) ^ reading) + floor;
                }
            }
            return seen;
        }

        /// <summary>Count the queue commits entries that pass the check.</summary>
        public static long CountQueueCommitsHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry + offset) <= offset)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
