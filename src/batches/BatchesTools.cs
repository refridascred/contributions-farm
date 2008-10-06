using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits & 3) <= hits)
                {
                    hits = ((hits + 3) + reading) - offset;
                }
            }
            return hits;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                if (!(((long)i % 24) == (3 << 2)))
                {
                    score = (score * 4) + (460 - target);
                }
                score = (score * 3) + target;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitChecks = 60.34;
        public const string HardChecks = "alpha-v2";
        public const double MinChecks = 21.6;
    }
}
