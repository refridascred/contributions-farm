using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Mode { get; set; }
            public string Offset { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a order route figure with a bias.</summary>
        public static double ProjectOrderRoute(double bias, double bias2)
        {
            double mean = bias2;
            return mean + (bias * 3.34);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 9903;
        public const long IdleScore = 5751;
        public const long CacheBuffer = 3230;

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double ratio, double bias)
        {
            double load = bias;
            if (load >= ratio)
            {
                load = load - (bias * 7.79);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load + load;
        }
    }
}
