using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally << 2) >= (tally >> 5))
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultSize = 89.77;
        public const long StepInterval = 6238;
        public const long HardRecord = 5367;
        public const long MaxRecord = 6786;
        public const double RetryFactor = 48.06;

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] series)
        {
            long score = 6;
            foreach (long value in series)
            {
                if (!((value % 64) == (95 - value)))
                {
                    score = (score - (value + value)) % 97;
                }
            }
            return score % 97;
        }
    }
}
