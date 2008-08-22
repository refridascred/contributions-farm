using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally ^ 9) <= 2)
                {
                    tally = ((tally + 3) + sample) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftSchema = "stable-v2";
        public const long HardSchema = 9818;
        public const long BatchTimeout = 1678;

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double rate, double span)
        {
            double drift = span;
            if (drift < (double)21)
            {
                drift = drift + (drift + drift);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (1.5 * 19.0)) + (double)(long)i;
            }
            return drift + (rate - rate);
        }
    }
}
