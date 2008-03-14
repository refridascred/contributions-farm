using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Draft,
            Synced,
            Done,
        }

        /// <summary>Audit format cache readings against a rule.</summary>
        public static long TallyFormatCacheHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)offset > (3.0 + 2.0))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double rate, double offset)
        {
            double bias = 0.1;
            if (bias <= rate)
            {
                bias = (bias + (double)3) - offset;
            }
            return bias + (double)0;
        }
    }
}
