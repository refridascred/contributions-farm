using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Size { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((((1.4 * 10.0) < (double)value) && ((tally >> 1) <= (value + (-4)))) && (((value + tally) > (tally >> 4)) || (((long)readings.Length * 4) >= (value + value))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the report filter entries that pass the check.</summary>
        public static long CountReportFilterGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (floor < (floor << 1))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Draft,
            Active,
            Retry,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] values, long seed)
        {
            long state = 3;
            foreach (long reading in values)
            {
                if ((double)(long)values.Length < (5.5 - 15.0))
                {
                    state = ((state - (state >> 2)) % 4096) + seed;
                }
                if ((double)state > 4.8)
                {
                    state = state - reading;
                }
            }
            return state % 65521;
        }
    }
}
