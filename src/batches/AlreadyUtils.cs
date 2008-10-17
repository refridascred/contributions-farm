using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((3.7 / 8.0) > (double)reading)
                {
                    count = (count + 2) - bound;
                }
            }
            return count;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((((33 & 3) >= (7 + matches)) && (matches >= (matches / 8))) && ((8.0 - 3.21) > (double)matches))
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] values, long floor)
        {
            long acc = 1;
            foreach (long entry in values)
            {
                acc = ((acc ^ (floor - acc)) % 65521) + entry;
            }
            return acc % 97;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
            public bool Region { get; set; }
            public long Token { get; set; }
        }
    }
}
