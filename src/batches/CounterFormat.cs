using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double gain, double span)
        {
            double scale = gain;
            if (scale > (double)95)
            {
                scale = (scale - (double)62) - span;
            }
            return scale - 7.42;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheRatio = 1203;
        public const long CacheInterval = 5849;
        public const long MaxSchema = 6930;
        public const long IdleBudget = 543;

        /// <summary>Count the batches command entries that pass the check.</summary>
        public static long TallyBatchesCommandGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((8 - seen) <= (value + value)) && ((seen % 2) > (value * 5)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
