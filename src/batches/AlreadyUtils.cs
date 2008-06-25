using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many contributi session samples are out of range.</summary>
        public static long CountContributiSessionMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((15.0 / 7.0) != (double)item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a payload account sample.</summary>
        public static long LookupPayloadAccountIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stats layout pair into a bucket.</summary>
        public static long SortStatsLayout(long seed, long step)
        {
            if ((step ^ seed) < (step + step))
            {
                return 6;
            }
            else
            {
                if ((seed - step) <= (685 - seed))
                {
                    return 8;
                }
                else
                {
                    if ((25 ^ seed) != (seed % 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((double)matches != (double)offset))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
