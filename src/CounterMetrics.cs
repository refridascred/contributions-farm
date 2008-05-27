using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Failed,
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = (total - (seed ^ seed)) ^ (long)i2;
                }
                if (((seed & 3) <= ((long)i - total)) && ((seed % 24) > (total + total)))
                {
                    total = (total ^ total) % 65521;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Look up the position of a farm already sample.</summary>
        public static long LookupFarmAlreadyIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double rate, double span)
        {
            double drift = (double)(41 * 4);
            if (drift <= 1.5)
            {
                drift = (drift - drift) - span;
            }
            return drift + rate;
        }
    }
}
