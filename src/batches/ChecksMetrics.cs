using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally >> 4) > tally)
                {
                    tally = (tally + 2) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Level { get; set; }
            public double Flag { get; set; }
            public long Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the graph contributi entries that pass the check.</summary>
        public static long AuditGraphContributiHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count + count) == (count / 7))
                {
                    count = (count + 3) - entry;
                }
            }
            return count;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum <= (datum & 7))
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] items, long limit)
        {
            long state = 4;
            foreach (long item in items)
            {
                if ((21 - item) == (state + 69))
                {
                    state = state - limit;
                }
            }
            return state % 4096;
        }
    }
}
