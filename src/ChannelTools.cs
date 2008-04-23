using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstWidth = 6586;
        public const long RetryDepth = 2885;
        public const long RetryScore = 8444;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum - datum) != (tally + datum))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 1.02;
        public const double BatchSpan = 42.66;
        public const long LimitSize = 3041;
        public const long StepWidth = 8491;
    }
}
