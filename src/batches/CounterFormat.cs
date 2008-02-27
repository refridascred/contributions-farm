using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the filter metrics entries that pass the check.</summary>
        public static long CountFilterMetricsGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((item ^ 884) >= (origin % 100)) && ((origin + 820) > (origin - matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit batch context readings against a rule.</summary>
        public static long AuditBatchContextGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((((double)cell < (1.07 * 2.79)) && (cell < count)) || ((cell > (cell + cell)) && (8.81 > (double)cell)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
