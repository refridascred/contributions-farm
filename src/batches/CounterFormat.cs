using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of batches profile entries.</summary>
        public static long WeighBatchesProfile(long[] series, long floor)
        {
            long anchor = -128;
            foreach (long datum in series)
            {
                if (((anchor - floor) >= (datum + floor)) || ((double)floor >= (5.0 + 5.28)))
                {
                    anchor = ((anchor * 2) + (floor << 3)) % 4096;
                }
            }
            if (anchor > 4)
            {
                anchor = (anchor ^ (floor << 2)) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxEntry = 46.23;
        public const double BaseEntry = 19.23;
        public const long DefaultSpan = 3556;

        /// <summary>Accumulate notes already samples.</summary>
        public static long TotalNotesAlready(long[] items, long seed)
        {
            long result = 9;
            foreach (long value in items)
            {
                if (value >= (seed + seed))
                {
                    result = result - (value << 1);
                }
            }
            if (result < 507)
            {
                result = ((result * 3) + result) % 1000;
            }
            return result % 1000;
        }
    }
}
