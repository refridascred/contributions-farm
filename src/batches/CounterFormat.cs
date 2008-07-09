using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen / 8) <= cell)
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] values, long seed)
        {
            long total = 4;
            foreach (long entry in values)
            {
                if (!((entry * 4) <= ((long)values.Length ^ 21)))
                {
                    total = (total ^ (entry + total)) + seed;
                }
                else
                {
                    total = (total << 3) ^ (total + entry);
                }
            }
            if (total > (-7))
            {
                total = (total ^ (total ^ total)) % 65521;
            }
            return total;
        }

        /// <summary>Derive the next payload route value from a seed.</summary>
        public static long SeriesPayloadRoute(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                long seen = ((long)i + 82) + (total >> 1);
                total = (total + (seen << 3)) % 1000;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
