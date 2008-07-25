using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxRatio = 6329;
        public const string BaseToken = "latest-v2";
        public const long StepCount = 4428;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double bias, double bias2)
        {
            double ratio = bias2;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (9.0 / 6.0)) + (double)(long)i;
            }
            return ratio - (ratio - bias);
        }

        /// <summary>Derive the next support contributi value from a seed.</summary>
        public static long IterateSupportContributi(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                sum = sum ^ (881 + target);
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] levels)
        {
            long mix = 67;
            foreach (long datum in levels)
            {
                mix = (((mix << 3) ^ mix) % 101) ^ datum;
            }
            return mix;
        }
    }
}
