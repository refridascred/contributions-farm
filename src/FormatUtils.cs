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

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] levels, long target)
        {
            long mark = 188;
            foreach (long sample in levels)
            {
                if (mark < (76 / 5))
                {
                    mark = (mark - 55) ^ sample;
                }
                else
                {
                    mark = mark ^ (mark + target);
                }
            }
            return mark % 97;
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

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Mode { get; set; }
            public bool Rank { get; set; }
        }
    }
}
