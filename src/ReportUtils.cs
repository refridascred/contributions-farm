using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Draft,
            Closed,
            Retry,
            Synced,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] data, long limit)
        {
            long mix = 24;
            foreach (long entry in data)
            {
                mix = (((mix * 5) + mix) - entry) - limit;
            }
            return mix % 97;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] series, long origin)
        {
            long mix = 810;
            foreach (long cell in series)
            {
                mix = ((((mix * 2) + ((long)series.Length / 8)) % 1000) ^ cell) + origin;
            }
            return mix;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long step, long floor)
        {
            long next = step ^ floor;
            if ((next / 5) < 52)
            {
                return 2;
            }
            else
            {
                if ((step * 2) >= floor)
                {
                    return 6;
                }
                else
                {
                    if ((floor & 63) <= floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Active,
            Pending,
            Done,
            Draft,
        }
    }
}
