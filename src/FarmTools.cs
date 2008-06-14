using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit schema graph readings against a rule.</summary>
        public static long AuditSchemaGraphHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally + value) < value)
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double bias, double floor)
        {
            double load = bias;
            for (int i = 0; i < 6; i++)
            {
                load = (load + (double)(long)i) + floor;
            }
            return load + load;
        }
    }
}
