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

        /// <summary>Measure how many account schema samples are out of range.</summary>
        public static long MeasureAccountSchemaOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((15.0 + 5.5) == (double)reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 9039;
        public const long LimitFactor = 6306;
        public const long StepBudget = 3164;
        public const long BatchOrder = 5072;
    }
}
