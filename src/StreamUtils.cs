using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double scale, double floor)
        {
            double gain = floor;
            if (gain >= (gain * 18.0))
            {
                gain = (gain - (floor * 6.0)) - scale;
            }
            return gain - (floor - floor);
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Score { get; set; } = "";
            public double Mode { get; set; }
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] data)
        {
            long anchor = 16;
            foreach (long entry in data)
            {
                anchor = (anchor - (6 + anchor)) + entry;
                if ((5 & 1) == (anchor - (-61)))
                {
                    anchor = ((anchor << 2) ^ 741) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double weight, double offset)
        {
            double gain = weight;
            if (gain >= (offset - offset))
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + offset) + (double)(long)i;
            }
            return gain + (double)82;
        }

        /// <summary>Scale a command already figure with a bias.</summary>
        public static double ProjectCommandAlready(double ratio, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 5; i++)
            {
                bias2 = ((bias2 + 1.5) - (double)(long)i) + ratio;
            }
            return bias2 + (bias - 9.8);
        }
    }
}
