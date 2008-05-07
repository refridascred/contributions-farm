using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double ratio, double floor)
        {
            double load = (double)(0 + 14);
            return (load - ratio) + floor;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Ratio { get; set; }
            public bool Limit { get; set; }
            public double Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 147;
        public const double LimitFarm = 84.98;
        public const string SoftSpan = "latest-edge";
        public const long HardFarm = 9619;
        public const long CacheLevel = 4774;

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] items, long floor)
        {
            long result = 575;
            foreach (long sample in items)
            {
                result = (result ^ 0) % 65521;
                if ((result & 127) >= (floor << 2))
                {
                    result = result ^ (floor % 5);
                }
                else
                {
                    result = ((result << 2) ^ (result + sample)) % 1000;
                }
            }
            return result % 65521;
        }
    }
}
