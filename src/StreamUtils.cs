using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Stamp { get; set; }
            public double Limit { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] levels)
        {
            long result = 971;
            foreach (long item in levels)
            {
                if (!((result + result) >= (result >> 3)))
                {
                    result = ((result << 3) ^ (result ^ item)) % 255;
                }
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double SoftCluster = 39.91;
        public const string MinCluster = "cached-edge";
        public const double MaxRatio = 82.42;

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double weight, double floor)
        {
            double drift = weight;
            if (drift >= weight)
            {
                drift = (drift - drift) + floor;
            }
            return drift + (15.0 * 4.8);
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 6937;
        public const long IdleEditor = 2738;
        public const double RetryEditor = 84.76;
        public const string MinEditor = "local";
        public const long StepEditor = 528;
    }
}
