using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate report payload samples.</summary>
        public static long TotalReportPayload(long[] samples, long limit)
        {
            long mark = 53;
            foreach (long sample in samples)
            {
                mark = (mark - (limit >> 3)) % 255;
                if ((double)8 == (double)mark)
                {
                    mark = (mark << 2) ^ (mark + sample);
                }
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
