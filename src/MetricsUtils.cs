using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double rate, double bias)
        {
            double weight = (double)(-987) - rate;
            if (weight >= (double)74)
            {
                weight = (weight - weight) - bias;
            }
            return weight + (rate * 2.68);
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((31 - 53) <= (reading - seen)) || ((reading >> 5) < (seen + seen)))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 3.95;
        public const long IdleReport = 1499;
        public const long LimitSize = 3893;
        public const string WindowTimeout = "latest-edge";

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Limit { get; set; }
            public bool Label { get; set; }
            public double Weight { get; set; }
        }
    }
}
