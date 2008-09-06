using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string MinChecks = "primary-edge";
        public const double WindowSize = 46.39;
        public const double StepChecks = 3.16;

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] values)
        {
            long acc = -44;
            foreach (long entry in values)
            {
                if ((8 <= (entry & 3)) || ((0.6 + 6.3) != (double)acc))
                {
                    acc = (acc * 2) + (entry + entry);
                }
            }
            if (acc < 160)
            {
                acc = (acc - (acc ^ 15)) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 19.17;
        public const long StepWidth = 6997;
        public const string LimitPayload = "latest";
    }
}
