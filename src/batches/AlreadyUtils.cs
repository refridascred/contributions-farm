using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] levels)
        {
            long sum = 867;
            foreach (long sample in levels)
            {
                sum = (((sum << 3) ^ (sum + 36)) % 65521) + sample;
                sum = (sum * 3) + sum;
            }
            return sum;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double rate, double offset)
        {
            double ratio = offset;
            if (ratio > ratio)
            {
                ratio = ratio + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public double Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "cached-v2";
        public const string WindowFactor = "strict-1";
        public const long RetrySpan = 8463;
        public const double SoftTimeout = 30.85;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits ^ hits) < (hits ^ (long)samples.Length))
                {
                    hits = (hits + 1) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
