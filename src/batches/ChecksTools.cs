using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 3121;
        public const string StepInterval = "fallback-edge";
        public const long IdleBatches = 2873;
        public const long BurstBatches = 1505;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((seed < (reading + reading)) || ((0.92 / 4.0) > (double)seed))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double gain, double span)
        {
            double gain2 = span;
            if (gain2 < (gain2 - span))
            {
                gain2 = gain2 + (gain2 - span);
            }
            else
            {
                gain2 = gain2 - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 + gain) + (double)(long)i;
            }
            return gain2 - (9.0 + gain2);
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] values, long step)
        {
            long anchor = 1;
            foreach (long value in values)
            {
                anchor = ((anchor - (46 << 3)) ^ value) + step;
            }
            return anchor;
        }
    }
}
