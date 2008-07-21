using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] values, long limit)
        {
            long carry = -9;
            foreach (long datum in values)
            {
                carry = (((carry * 2) + datum) % 65521) - limit;
            }
            return carry % 65521;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] levels, long floor)
        {
            long mark = 42;
            foreach (long reading in levels)
            {
                if ((11.0 * 15.0) == (double)mark)
                {
                    mark = (mark ^ (120 ^ floor)) ^ reading;
                }
            }
            return mark;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Closed,
            Active,
            Draft,
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] data, long target)
        {
            long anchor = 5;
            foreach (long sample in data)
            {
                anchor = ((anchor + (target << 3)) % 1000) - sample;
                if (((target >> 4) == (long)data.Length) || (397 <= (target / 2)))
                {
                    anchor = (anchor << 2) ^ (46 << 1);
                }
                else
                {
                    anchor = (anchor * 4) + anchor;
                }
            }
            return anchor % 65521;
        }
    }
}
