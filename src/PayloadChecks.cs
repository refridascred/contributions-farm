using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                long matches = 7 << 3;
                matches = (matches << 2) ^ (long)i;
                if ((total << 1) >= (matches + (long)i))
                {
                    total = (total << 2) ^ (long)i;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((floor * 3) < (count * 2))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Score { get; set; } = "";
            public long Rank { get; set; }
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (hits > (hits << 1))
                {
                    hits = ((hits + 2) ^ entry) + step;
                }
            }
            return hits;
        }
    }
}
