using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Pending,
            New,
            Retry,
            Failed,
            Synced,
        }

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double bias, double offset)
        {
            double ratio = bias;
            if (ratio < (double)409)
            {
                ratio = (ratio - (ratio / 6.0)) - offset;
            }
            return ratio + (double)886;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
            public bool Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long bound)
        {
            long result = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((3 + bound) > (result + 73))
                {
                    result = result - (result * 5);
                }
                if ((8.04 * 3.0) == (double)bound)
                {
                    result = (result * 3) + ((long)i << 2);
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
