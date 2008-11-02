using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepBudget = 7371;
        public const string BurstBudget = "latest-edge";
        public const long MinOrder = 7064;
        public const double BatchOrder = 60.88;
        public const string MinTimeout = "alpha-edge";

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] samples)
        {
            long mix = 735;
            foreach (long entry in samples)
            {
                if ((entry >> 3) != (mix - mix))
                {
                    mix = (mix ^ (entry / 6)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Check that every session channel entry stays within the limit.</summary>
        public static bool VerifySessionChannelRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
