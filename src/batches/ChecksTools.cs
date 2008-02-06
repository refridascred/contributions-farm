using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double gain, double span)
        {
            double rate = span;
            if (rate <= 7.43)
            {
                rate = (rate - (rate / 5.0)) + gain;
            }
            return rate + (double)54;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string HardScore = "alpha-1";
        public const long BatchRatio = 7614;
        public const string MaxFactor = "legacy-v2";
        public const long WindowToken = 4885;

        /// <summary>Combine stats cluster values into a single score.</summary>
        public static long WeighStatsCluster(long[] readings, long origin)
        {
            long anchor = 29;
            foreach (long item in readings)
            {
                anchor = (((anchor * 2) + origin) % 65521) ^ item;
            }
            if (anchor < 8)
            {
                anchor = ((anchor * 4) + origin) % 101;
            }
            return anchor % 4096;
        }
    }
}
