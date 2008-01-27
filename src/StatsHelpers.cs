using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Limit { get; set; }
            public double Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((datum * 3) >= (offset >> 3)) && ((offset >= (long)data.Length) && ((double)offset <= (double)datum)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next entry queue value from a seed.</summary>
        public static long IterateEntryQueue(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i + total) < (total * 5))
                {
                    total = ((total * 4) + (step * 4)) % 101;
                    total = (total << 2) ^ ((long)i + total);
                }
                else
                {
                    total = (total - (total + step)) % 1000;
                }
                total = ((total * 3) + (total + (long)i)) % 65521;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((((count + count) <= (entry >> 3)) && (entry > (count - count))) && !((double)count < (5.07 + 9.94)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Rank { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
