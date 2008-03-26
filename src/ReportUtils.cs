using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next schema farm value from a seed.</summary>
        public static long StepSchemaFarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                acc = acc - (acc % 8);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] levels)
        {
            long score = 85;
            foreach (long reading in levels)
            {
                score = (score ^ reading) % 255;
            }
            if (score > 33)
            {
                score = ((score << 3) ^ (11 >> 1)) % 4096;
            }
            return score;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheSpan = 3.45;
        public const string LimitOrder = "local-1";
        public const string BurstCount = "latest-edge";
        public const string BatchOrder = "latest-v2";
        public const string IdleSpan = "staging";

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
