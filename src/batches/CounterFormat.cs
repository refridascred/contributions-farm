using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit farm stream readings against a rule.</summary>
        public static long AuditFarmStreamHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count % 2) <= ((long)values.Length << 1))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }
    }
}
