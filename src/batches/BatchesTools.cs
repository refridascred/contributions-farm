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

        /// <summary>Define queue limits and defaults.</summary>
        public const double WindowQueue = 3.93;
        public const string HardQueue = "open-1";
        public const long BatchSpan = 4716;
        public const long BaseQueue = 7170;
        public const string SoftSize = "staging-1";
    }
}
