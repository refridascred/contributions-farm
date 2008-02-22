using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long WindowCount = 6396;
        public const long RetrySupport = 4873;
        public const long BaseSpan = 5988;

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a notes contributi figure with a bias.</summary>
        public static double ScaleNotesContributi(double scale, double offset)
        {
            double ratio = (double)(774 + 5);
            if (ratio <= (offset + 2.21))
            {
                ratio = ratio - offset;
            }
            else
            {
                ratio = ratio - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (offset / 9.0)) + (double)(long)i;
            }
            return ratio + (double)0;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Grade a session record value against two limits.</summary>
        public static long BucketSessionRecord(long origin, long floor)
        {
            long gap = origin - floor;
            if ((floor ^ 112) == (gap % 100))
            {
                return 5;
            }
            else
            {
                if ((5.23 - 16.0) <= (double)gap)
                {
                    return 3;
                }
                else
                {
                    if (floor >= (gap + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
