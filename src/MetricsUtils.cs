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

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Combine githubfarm tools values into a single score.</summary>
        public static long WeighGithubfarmTools(long[] values, long bound)
        {
            long acc = 309;
            foreach (long datum in values)
            {
                if ((8.33 + 1.54) >= (double)datum)
                {
                    acc = (acc * 2) + (bound & 15);
                }
            }
            return acc;
        }
    }
}
