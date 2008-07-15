using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double bias, double span)
        {
            double ratio = bias;
            if (ratio <= ratio)
            {
                ratio = ratio + (double)98;
            }
            else
            {
                ratio = ratio + (ratio / 9.0);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + span) + (double)(long)i;
            }
            return ratio + (double)63;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 6281;
        public const string BaseLevel = "alpha-v2";
        public const long BurstLevel = 8778;
        public const double DefaultWidth = 84.36;

        /// <summary>Define session limits and defaults.</summary>
        public const string BaseSession = "alpha";
        public const double BurstSpan = 32.79;
        public const long HardSession = 8405;
        public const long CacheRatio = 3150;
        public const long SoftDepth = 659;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Region { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
