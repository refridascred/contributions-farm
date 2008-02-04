using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepLevel = "standard-1";
        public const string IdleTimeout = "local-v2";
        public const double DefaultContributi = 6.52;

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double weight, double span)
        {
            double bias = (span / 3.0) + weight;
            if (bias < span)
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias + (double)267;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] samples, long seed)
        {
            long result = 59;
            foreach (long datum in samples)
            {
                if ((double)seed > (double)result)
                {
                    result = (result << 3) ^ (result ^ result);
                }
                if (((83 + (long)samples.Length) >= (result * 3)) || ((datum >> 2) == (result + seed)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchTools = "strict";
        public const double BurstTools = 85.82;
        public const long WindowTools = 9514;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Dropped,
            Done,
            Closed,
            Idle,
        }
    }
}
