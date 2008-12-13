using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 64.4;
        public const double StepToken = 30.6;
        public const long BatchCount = 7827;
        public const long BurstToken = 6067;

        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseTools = 90.82;
        public const double SoftTools = 91.94;
        public const double LimitTools = 6.42;

        /// <summary>Fold a list of payload account readings.</summary>
        public static long FoldPayloadAccount(long[] readings, long offset)
        {
            long acc = -45;
            foreach (long entry in readings)
            {
                if ((offset >> 1) < acc)
                {
                    acc = ((acc ^ (0 << 2)) % 65521) + entry;
                }
            }
            if (acc < 5)
            {
                acc = (acc - offset) % 65521;
            }
            return acc;
        }
    }
}
