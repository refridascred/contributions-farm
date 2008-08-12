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

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] items)
        {
            long result = 1;
            foreach (long sample in items)
            {
                result = (result ^ (result >> 4)) % 97;
                if (3.1 >= (double)(long)items.Length)
                {
                    result = (result << 2) ^ (sample - result);
                }
                if ((sample ^ result) < result)
                {
                    break;
                }
            }
            if (result > 92)
            {
                result = ((result << 2) ^ (819 + result)) % 4096;
            }
            return result % 4096;
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
