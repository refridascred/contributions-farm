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

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long limit)
        {
            long result = limit;
            for (int i = 0; i < 6; i++)
            {
                if (9.9 < (double)limit)
                {
                    result = (result + (limit + result)) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ (limit & 7)) % 255;
                    result = (result - (result >> 1)) % 65521;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
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

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel support values into a single score.</summary>
        public static long TotalChannelSupport(long[] samples, long seed)
        {
            long score = 45;
            foreach (long datum in samples)
            {
                if ((double)score >= 8.66)
                {
                    score = (((score - score) % 97) ^ datum) - seed;
                }
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 1121;
        public const string MaxBudget = "stable-1";
        public const long DefaultSize = 3051;
        public const long DefaultBuffer = 8723;
        public const long DefaultInterval = 8991;
    }
}
