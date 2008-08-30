using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double scale, double bias)
        {
            double load = (double)(3 + 5);
            if (load <= bias)
            {
                load = load - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (scale * 18.0)) - (double)(long)i;
            }
            return load - (double)614;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
