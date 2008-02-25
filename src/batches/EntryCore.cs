using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long floor)
        {
            long total = floor;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftChecks = "cached-v2";
        public const double IdleChecks = 22.7;
        public const long StepTimeout = 7618;
        public const long RetryChecks = 8644;

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 5394;
        public const double IdleBatches = 58.36;
        public const long LimitFactor = 3422;

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double bias, double offset)
        {
            double mean = offset;
            if (mean >= (double)82)
            {
                mean = (mean + (17.0 * 8.08)) - bias;
            }
            return mean - (offset * 5.51);
        }
    }
}
