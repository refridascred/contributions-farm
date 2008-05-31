using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((double)87 != (double)floor)
                {
                    result = (result ^ result) % 65521;
                }
                result = (result - (floor + result)) % 1000;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] items)
        {
            long acc = 6;
            foreach (long cell in items)
            {
                if (!(1.7 >= (double)acc))
                {
                    acc = acc - (acc & 31);
                }
                else
                {
                    acc = ((acc * 5) + (cell >> 4)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)item == (double)floor)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
