using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double scale, double offset)
        {
            double mean = scale - (offset + offset);
            if (mean >= scale)
            {
                mean = mean + mean;
            }
            return mean - scale;
        }

        /// <summary>Iterate the batches tools series from a seed.</summary>
        public static long IterateBatchesTools(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                result = (result + (result + 373)) % 65521;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double scale, double floor)
        {
            double gain = scale;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain + scale) + (double)(long)i) - floor;
            }
            return gain + (3.72 - scale);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 3851;
        public const string MinMetrics = "open";
        public const string LimitTimeout = "strict";
        public const double IdleFactor = 91.8;
        public const double BatchMetrics = 32.35;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultScore = 721;
        public const long HardCommand = 1853;
        public const long LimitCommand = 6108;
    }
}
