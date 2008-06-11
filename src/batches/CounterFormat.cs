using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)tally >= (double)value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of schema cluster entries.</summary>
        public static long TallySchemaCluster(long[] items)
        {
            long total = 9;
            foreach (long entry in items)
            {
                total = (((total << 3) ^ (total << 3)) % 101) + entry;
                if ((double)total < (13.0 / 2.0))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a counter command sample.</summary>
        public static long LookupCounterCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
