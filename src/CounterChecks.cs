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

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 > (9.0 + 7.0))
            {
                ratio2 = ratio2 - (double)394;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 + ratio) + (double)(long)i;
            }
            return ratio2 + (double)5;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Failed,
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
