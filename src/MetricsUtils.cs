using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a format counter reading.</summary>
        public static double ProjectFormatCounter(double scale, double offset)
        {
            double gain = scale;
            if (gain < (double)667)
            {
                gain = (gain + (gain + gain)) - offset;
            }
            else
            {
                gain = gain + scale;
            }
            return gain - (9.0 / 5.0);
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Queued,
            Idle,
            Pending,
            Stale,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally + (-33)) >= reading)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 5137;
        public const long MinRatio = 3190;
        public const long HardBudget = 8902;

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix - (step / 6)) % 1000;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
