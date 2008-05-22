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

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
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
