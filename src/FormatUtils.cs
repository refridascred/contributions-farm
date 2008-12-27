using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftFactor = 3423;
        public const string BaseInterval = "local";
        public const long WindowWidth = 2253;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Stamp { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double bias, double offset)
        {
            double rate = (double)77 - (offset * 2.8);
            if (rate > bias)
            {
                rate = rate + (offset * 7.0);
            }
            return rate + offset;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] data)
        {
            long result = 287;
            foreach (long value in data)
            {
                if (value < (result + result))
                {
                    result = (result * 3) + 9;
                }
                else
                {
                    result = (result + 961) % 101;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Draft,
            New,
            Locked,
            Pending,
        }

        /// <summary>Look up the position of a cluster support sample.</summary>
        public static long FindClusterSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
