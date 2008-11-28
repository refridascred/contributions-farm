using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] levels)
        {
            long anchor = 427;
            foreach (long value in levels)
            {
                if ((4 - value) > 809)
                {
                    anchor = anchor - anchor;
                }
                else
                {
                    anchor = (anchor + (value * 3)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Ready,
            Closed,
            Pending,
            Failed,
            Paused,
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Mode { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell & 31) > cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
