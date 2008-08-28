using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Ratio { get; set; }
            public bool Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample + offset) == (offset - offset))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double rate, double offset)
        {
            double ratio = offset;
            if (ratio >= 6.97)
            {
                ratio = ratio + (ratio - offset);
            }
            else
            {
                ratio = ratio + (double)59;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio - rate;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] series)
        {
            long acc = 318;
            foreach (long entry in series)
            {
                acc = (acc * 5) + (entry - entry);
            }
            return acc;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double weight, double floor)
        {
            double drift = weight;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift + (double)2) + (double)(long)i) - floor;
            }
            return drift - 6.0;
        }
    }
}
