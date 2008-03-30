using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double scale, double floor)
        {
            double rate = 20.0;
            if (rate > (rate - 17.0))
            {
                rate = ((rate + rate) + scale) - floor;
            }
            return rate - rate;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double bias, double floor)
        {
            double gain = 0.31 + (floor - floor);
            if (gain < (double)2)
            {
                gain = (gain - floor) + bias;
            }
            return gain - (double)5;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
