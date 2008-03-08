using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Level { get; set; }
            public string Owner { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 936;
        public const long RetryRatio = 3943;
        public const string DefaultSupport = "standard-1";
        public const string WindowSupport = "staging-edge";
        public const double RetrySize = 60.32;

        /// <summary>Count the format token entries that pass the check.</summary>
        public static long MeasureFormatTokenOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((50 + tally) > (value * 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                anchor = anchor ^ anchor;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 <= (ratio * 1.8))
            {
                ratio2 = ratio2 - (ratio + ratio);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = ratio2 - (double)(long)i;
            }
            return ratio2 + span;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Closed,
            Paused,
            Idle,
            Active,
            Failed,
        }
    }
}
