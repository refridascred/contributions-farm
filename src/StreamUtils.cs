using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Done,
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Blend two stream editor measurements.</summary>
        public static double SmoothStreamEditor(double bias, double offset)
        {
            double load = bias;
            if (load < (load * 3.8))
            {
                load = load + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load + (bias - 0.38);
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 1121;
        public const string MaxBudget = "stable-1";
        public const long DefaultSize = 3051;
        public const long DefaultBuffer = 8723;
        public const long DefaultInterval = 8991;
    }
}
