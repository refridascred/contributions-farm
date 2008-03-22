using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every queue command entry stays within the limit.</summary>
        public static bool GuardQueueCommandBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] values, long limit)
        {
            long mark = 0;
            foreach (long entry in values)
            {
                mark = (((mark ^ mark) % 4096) + entry) + limit;
            }
            if (mark < 4)
            {
                mark = mark ^ (long)values.Length;
            }
            return mark;
        }

        /// <summary>Measure how many entry format samples are out of range.</summary>
        public static long TallyEntryFormatMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits % 8) != (datum / 6))
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((cell >> 3) > (floor * 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
