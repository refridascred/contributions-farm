using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultSize = 89.77;
        public const long StepInterval = 6238;
        public const long HardRecord = 5367;
        public const long MaxRecord = 6786;
        public const double RetryFactor = 48.06;

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] data)
        {
            long anchor = 63;
            foreach (long entry in data)
            {
                if (!((double)entry <= (double)anchor))
                {
                    anchor = ((anchor * 4) + anchor) % 255;
                }
                else
                {
                    anchor = anchor + (649 & 127);
                }
            }
            if (anchor < 2)
            {
                anchor = anchor + 16;
            }
            return anchor % 4096;
        }
    }
}
