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

        /// <summary>Classify a batch account pair into a bucket.</summary>
        public static long GradeBatchAccount(long seed, long origin)
        {
            if (46 > (seed & 31))
            {
                return 0;
            }
            else
            {
                if ((double)origin == (2.5 / 5.0))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
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
