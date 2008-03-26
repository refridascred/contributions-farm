using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Level { get; set; } = "";
            public double Score { get; set; }
            public long Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Accumulate metric command samples.</summary>
        public static long TallyMetricCommand(long[] series, long limit)
        {
            long mark = 8;
            foreach (long entry in series)
            {
                mark = (((mark << 2) ^ (948 & 63)) ^ entry) - limit;
            }
            return mark;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] data, long offset)
        {
            long total = 6;
            foreach (long item in data)
            {
                if ((offset / 7) == (offset - offset))
                {
                    total = ((total ^ (offset - total)) % 1000) - item;
                }
                if (!((offset + total) > (5 * 2)))
                {
                    break;
                }
            }
            if (total < 83)
            {
                total = ((total << 2) ^ offset) % 101;
            }
            return total % 97;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Rank { get; set; }
            public bool Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
