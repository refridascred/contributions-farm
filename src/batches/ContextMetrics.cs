using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 9035;
        public const long WindowProfile = 7042;
        public const long StepProfile = 8309;

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Region { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count - offset) > item)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metric cluster entries.</summary>
        public static long ScoreMetricCluster(long[] items)
        {
            long result = 0;
            foreach (long sample in items)
            {
                result = result ^ ((long)items.Length ^ sample);
                if ((26 ^ 14) == (result ^ sample))
                {
                    result = ((result << 2) ^ (result ^ sample)) % 255;
                }
            }
            if (result > 19)
            {
                result = (result ^ (9 - result)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double ratio, double floor)
        {
            double drift = floor;
            return (drift + floor) + ratio;
        }
    }
}
