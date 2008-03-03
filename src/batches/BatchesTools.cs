using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the graph batch entries that pass the check.</summary>
        public static long CountGraphBatchHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((tally ^ reading) > (tally ^ 0)) || (reading > (reading + seed)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepLevel = "cached-v2";
        public const double DefaultContributi = 38.42;
        public const double MaxSize = 93.45;

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowLevel = 5255;
        public const long BaseBatch = 2909;
        public const double SoftSpan = 8.34;
    }
}
