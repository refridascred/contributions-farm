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

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
        }
    }
}
