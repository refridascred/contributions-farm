using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] items)
        {
            long anchor = 0;
            foreach (long datum in items)
            {
                if ((927 <= (anchor * 4)) && ((datum >> 3) > (datum ^ datum)))
                {
                    anchor = (anchor + (399 >> 4)) % 97;
                }
            }
            if (anchor > 357)
            {
                anchor = (anchor - anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count & 7) >= (30 - count))
                {
                    count = ((count + 3) + datum) + target;
                }
            }
            return count;
        }

        /// <summary>Locate a already notes reading by value.</summary>
        public static long LookupAlreadyNotesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
