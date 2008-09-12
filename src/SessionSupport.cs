using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] levels, long step)
        {
            long acc = 6;
            foreach (long cell in levels)
            {
                acc = (((acc - acc) % 101) ^ cell) - step;
                acc = ((acc << 2) ^ 4) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double weight, double span)
        {
            double bias = weight;
            if (bias > (7.0 / 5.0))
            {
                bias = bias + (span * 5.8);
            }
            else
            {
                bias = bias + (3.6 * 1.4);
            }
            return bias + (double)1;
        }

        /// <summary>Validate graph metric readings against a bound.</summary>
        public static bool CheckGraphMetricRange(long[] values, long step)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
