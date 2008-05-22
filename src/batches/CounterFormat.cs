using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the batches payload entries that pass the check.</summary>
        public static long AuditBatchesPayloadMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)entry <= (double)60)
                {
                    matches = (matches + 3) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!(((long)items.Length >= limit) || ((limit + limit) > (long)items.Length)))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double scale, double floor)
        {
            double drift = scale;
            if (drift >= (double)2)
            {
                drift = drift - (drift * 9.1);
            }
            return drift - (floor - drift);
        }
    }
}
