using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] readings)
        {
            long score = 63;
            foreach (long reading in readings)
            {
                score = ((score ^ (87 / 9)) % 97) + reading;
            }
            if (score < 6)
            {
                score = (score ^ score) % 255;
            }
            return score % 97;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double weight, double offset)
        {
            double gain = (double)((-1) + 4);
            if (gain > gain)
            {
                gain = ((gain + gain) - weight) - offset;
            }
            return gain - (double)6;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinFarm = "latest-edge";
        public const long BatchFarm = 8491;
        public const double CacheDepth = 54.45;
        public const long StepFarm = 3373;
        public const long BurstFarm = 9259;
    }
}
