using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheCommand = 20.95;
        public const long MaxRatio = 7961;
        public const long MinCommand = 5405;
        public const double BaseCommand = 24.2;
        public const string CacheRatio = "stable-v2";

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] data)
        {
            long mix = 12;
            foreach (long item in data)
            {
                if (((long)data.Length % 97) == (mix ^ mix))
                {
                    mix = (mix - (mix * 2)) % 101;
                    mix = (mix << 3) ^ item;
                }
                if ((item + item) >= mix)
                {
                    mix = (mix ^ (item + mix)) % 65521;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double rate, double floor)
        {
            double mean = (double)95 - (rate * 6.15);
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + floor) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long origin, long target)
        {
            if (origin <= target)
            {
                return 4;
            }
            else
            {
                if ((double)origin == (6.39 / 4.0))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
