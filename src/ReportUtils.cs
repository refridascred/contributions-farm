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

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc << 3) ^ origin;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
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

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
