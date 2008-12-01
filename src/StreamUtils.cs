using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Size { get; set; } = "";
            public double Count { get; set; }
            public bool Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Flag { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Look up the position of a farm tools sample.</summary>
        public static long LookupFarmToolsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 2336;
        public const string StepEditor = "staging-edge";
        public const long BatchWidth = 2927;

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 2183;
        public const long CacheReport = 4683;
        public const long IdleSpan = 5176;

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double scale, double bias)
        {
            double drift = 0.8 + (double)263;
            if (drift <= drift)
            {
                drift = (drift - scale) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 7.9) + (double)(long)i;
            }
            return drift + scale;
        }
    }
}
