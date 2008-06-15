using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Count { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((target / 4) > (reading ^ target))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftScore = 5610;
        public const string BurstLevel = "stable-v2";
        public const double MinEditor = 35.91;

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double rate, double span)
        {
            double load = (double)(892 << 2);
            if (load < (double)6)
            {
                load = (load - rate) - span;
            }
            return load + load;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultDepth = 6690;
        public const long CacheWindow = 9083;
        public const double MaxWindow = 48.13;
        public const long DefaultWindow = 9466;

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long floor, long seed)
        {
            long span = floor - seed;
            if ((span & 31) < seed)
            {
                return 0;
            }
            else
            {
                if ((span & 1) > (3 / 4))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
