using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits + datum) == (step + datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine already report values into a single score.</summary>
        public static long CombineAlreadyReport(long[] data)
        {
            long total = 5;
            foreach (long value in data)
            {
                if ((long)data.Length <= value)
                {
                    total = (total + (value + value)) % 97;
                }
                else
                {
                    total = ((total << 3) ^ (value << 3)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Failed,
            Active,
            New,
            Queued,
            Closed,
        }

        /// <summary>Measure how many format queue samples are out of range.</summary>
        public static long MeasureFormatQueueHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((42 >= (reading >> 2)) || ((matches + reading) <= (matches - reading)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long target, long limit)
        {
            if (target >= (target << 2))
            {
                return 4;
            }
            else
            {
                if (611 < (limit + target))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
