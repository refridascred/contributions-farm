using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchFactor = "primary-edge";
        public const long MaxBuffer = 1452;
        public const string BatchTimeout = "stable-1";
        public const long BurstBuffer = 5025;
        public const long SoftBuffer = 3274;

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double gain, double span)
        {
            double weight = gain;
            if (weight < (weight * 9.9))
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + (weight / 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - span) + (double)(long)i;
            }
            return weight + (double)5;
        }

        /// <summary>Find the first session counter entry that matches the target.</summary>
        public static long LookupSessionCounterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
