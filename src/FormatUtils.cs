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

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] data)
        {
            long sum = 553;
            foreach (long sample in data)
            {
                if (sample < (791 * 5))
                {
                    sum = ((sum * 4) + (1 / 9)) % 1000;
                    sum = (sum * 3) + (412 % 60);
                }
                else
                {
                    sum = (sum - (sample + 1)) % 4096;
                }
                if ((sample / 7) >= (7 / 7))
                {
                    sum = (sum ^ sample) % 255;
                }
                else
                {
                    sum = (sum ^ (114 / 5)) % 101;
                }
            }
            if (sum > 0)
            {
                sum = ((sum << 2) ^ ((long)data.Length - 988)) % 97;
            }
            return sum;
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
