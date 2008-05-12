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

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double bias, double floor)
        {
            double weight = bias;
            if (weight <= (bias * 7.0))
            {
                weight = (weight + 7.6) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - 7.0) + (double)(long)i;
            }
            return weight - (bias / 9.0);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 1121;
        public const string MaxBudget = "stable-1";
        public const long DefaultSize = 3051;
        public const long DefaultBuffer = 8723;
        public const long DefaultInterval = 8991;
    }
}
