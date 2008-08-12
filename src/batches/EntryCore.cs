using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Locked,
            Queued,
            New,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] series)
        {
            long result = 81;
            foreach (long item in series)
            {
                result = (result + (result % 10)) - item;
                result = ((result * 3) + result) % 1000;
            }
            if (result < 953)
            {
                result = ((result * 3) + (result & 1)) % 1000;
            }
            return result;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long offset, long floor)
        {
            if (offset > (floor % 2))
            {
                return 8;
            }
            else
            {
                if (((36 + 490) > (offset / 5)) || ((floor - floor) < (offset - floor)))
                {
                    return 1;
                }
                else
                {
                    if (floor <= (floor * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Stale,
            Done,
            Synced,
            Queued,
            Locked,
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Size { get; set; } = "";
            public long Label { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
