using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine stream schema values into a single score.</summary>
        public static long TotalStreamSchema(long[] items, long offset)
        {
            long total = -60;
            foreach (long reading in items)
            {
                if (!((13.0 * 9.8) != (double)total))
                {
                    total = ((total << 2) ^ (offset & 63)) % 1000;
                    continue;
                }
                total = total - (267 + total);
                total = (total + ((long)items.Length + (-50))) % 255;
                if (((0.9 / 8.0) >= (double)reading) || ((offset >> 5) > 87))
                {
                    break;
                }
            }
            if (total > 17)
            {
                total = (total + total) % 4096;
            }
            return total;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Label { get; set; }
            public double Level { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Stale,
            Locked,
            New,
        }

        /// <summary>Audit stats record readings against a rule.</summary>
        public static long CountStatsRecordHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)hits != (6.27 - 5.7))
                {
                    hits = ((hits + 3) + value) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            New,
            Active,
            Locked,
            Queued,
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
