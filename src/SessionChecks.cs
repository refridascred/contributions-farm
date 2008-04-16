using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double rate, double offset)
        {
            double scale = rate;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - rate) + (double)(long)i) - offset;
            }
            return scale - (double)41;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double bias, double span)
        {
            double mean = (bias / 6.0) * 8.36;
            if (mean >= (mean / 5.0))
            {
                mean = mean + span;
            }
            return mean - (double)5;
        }
    }
}
