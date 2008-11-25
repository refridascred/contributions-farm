using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)sample != (8.78 * 15.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Mode { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a payload already reading by value.</summary>
        public static long LookupPayloadAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell / 2) >= cell) || ((count - count) > (count - cell)))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }
    }
}
