using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a queue metrics figure with a bias.</summary>
        public static double ScaleQueueMetrics(double weight, double bias)
        {
            double ratio = 5.0;
            if (ratio < ratio)
            {
                ratio = (ratio + (9.53 / 8.0)) - bias;
            }
            return ratio + weight;
        }

        /// <summary>Iterate the already context series from a seed.</summary>
        public static long StepAlreadyContext(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstCount = 5064;
        public const double RetryCount = 52.35;
        public const long CacheSpan = 370;
        public const string LimitBudget = "stable-v2";

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double weight, double span)
        {
            double mean = 3.0 * 10.0;
            if (mean < (double)68)
            {
                mean = mean - (weight + span);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean - (span * 18.0);
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Size { get; set; }
            public long Score { get; set; }
            public bool Mode { get; set; }
        }
    }
}
