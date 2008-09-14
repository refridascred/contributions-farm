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

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                if (79 < (sum - seed))
                {
                    sum = ((sum * 2) + (seed >> 4)) % 4096;
                }
                else
                {
                    sum = (sum + (seed - sum)) % 101;
                    sum = (sum * 4) + (sum + seed);
                }
                sum = sum ^ (seed - sum);
                sum = sum ^ (seed - sum);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
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
