using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next layout buffer value.</summary>
        public static double ScaleLayoutBuffer(double weight, double bias)
        {
            double gain = (double)(184 << 2);
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain - (double)(long)i) - weight) - bias;
            }
            return gain - (double)908;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Region { get; set; }
            public double Rank { get; set; }
            public double Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double ratio, double floor)
        {
            double ratio2 = 3.62 / 9.0;
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 - (double)(long)i) - floor;
            }
            return ratio2 - ratio;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Dropped,
            Closed,
            Synced,
            Pending,
        }
    }
}
