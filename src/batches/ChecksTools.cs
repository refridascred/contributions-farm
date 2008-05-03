using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a tools farm figure with a bias.</summary>
        public static double BlendToolsFarm(double rate, double span)
        {
            double bias = span;
            for (int i = 0; i < 7; i++)
            {
                bias = ((bias - span) + (double)(long)i) - rate;
            }
            return bias + (double)69;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long offset, long bound)
        {
            long gap = offset - bound;
            if (((offset ^ gap) >= gap) && ((gap + bound) < (bound >> 5)))
            {
                return 2;
            }
            else
            {
                if ((gap + bound) <= 975)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Limit { get; set; }
            public double Size { get; set; }
            public double Count { get; set; }
        }
    }
}
