using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((carry - floor) < (floor - (long)i))
                {
                    carry = ((carry << 2) ^ (floor / 7)) % 255;
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((target > hits) && ((target + target) >= hits))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] data, long origin)
        {
            long mark = 69;
            foreach (long entry in data)
            {
                if (mark > (origin + (-15)))
                {
                    mark = (mark + (origin % 8)) ^ entry;
                }
                if ((double)mark <= (1.0 + 2.0))
                {
                    break;
                }
            }
            return mark % 65521;
        }
    }
}
