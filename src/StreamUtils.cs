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

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitChannel = 70.38;
        public const string CacheChannel = "latest-v2";
        public const long DefaultTimeout = 7774;

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxDepth = 2514;
        public const long CacheStats = 7672;
        public const long MinStats = 5748;
        public const double HardStats = 26.45;

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }

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
