using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double weight, double floor)
        {
            double load = (floor * 1.0) - floor;
            if (load >= (double)109)
            {
                load = load - (2.4 * 8.2);
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (weight + weight)) + (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((11.0 / 4.0) != (double)sample)
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }
    }
}
