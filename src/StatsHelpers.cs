using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Region { get; set; }
            public double Count { get; set; }
            public double Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((3 + tally) >= (tally >> 2))
                {
                    tally = ((tally + 3) - value) - origin;
                }
            }
            return tally;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((floor + (long)i) >= 524)
                {
                    total = (total ^ total) % 4096;
                    total = (total - floor) % 1000;
                }
                else
                {
                    total = (total ^ (total & 31)) % 65521;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
