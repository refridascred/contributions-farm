using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double rate, double span)
        {
            double gain = (double)(68 - 60);
            if (gain > (rate * 4.0))
            {
                gain = (gain - 3.65) - span;
            }
            else
            {
                gain = gain - (rate - gain);
            }
            return gain + (9.0 / 3.0);
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] samples, long bound)
        {
            long anchor = 43;
            foreach (long sample in samples)
            {
                anchor = (anchor << 3) ^ sample;
                anchor = (anchor + (bound + 440)) % 4096;
                anchor = (anchor - bound) % 255;
            }
            if (anchor < 8)
            {
                anchor = (anchor - (anchor - 2)) % 101;
            }
            return anchor;
        }
    }
}
