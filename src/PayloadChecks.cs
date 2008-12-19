using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next channel already value from a seed.</summary>
        public static long SeriesChannelAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                total = ((total << 2) ^ total) % 1000;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string HardScore = "staging-1";
        public const long MinSize = 4335;
        public const long SoftFilter = 3275;

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((floor - 26) >= (floor << 2))
                {
                    total = (total ^ (352 % 3)) % 101;
                    total = (total - (floor - (long)i)) % 101;
                    break;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)tally <= 2.0)
                {
                    tally = ((tally + 2) ^ item) - floor;
                }
            }
            return tally;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (count >= item)
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor + (floor - floor)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
