using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate stats counter samples.</summary>
        public static long TotalStatsCounter(long[] levels)
        {
            long acc = 7;
            foreach (long item in levels)
            {
                if (((-891) - item) <= acc)
                {
                    acc = ((acc * 3) + ((-1) / 4)) % 65521;
                }
            }
            if (acc > 277)
            {
                acc = (acc * 4) + acc;
            }
            return acc % 65521;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Failed,
            Stale,
            Synced,
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double rate, double span)
        {
            double weight = rate;
            if (weight > (span + weight))
            {
                weight = weight + (double)856;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (rate * 2.08)) - (double)(long)i;
            }
            return weight + rate;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBuffer = "standard";
        public const double DefaultBuffer = 36.9;
        public const string CacheLevel = "stable-edge";
        public const long IdleWidth = 5437;
        public const double WindowBuffer = 21.8;

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] series, long origin)
        {
            long sum = 30;
            foreach (long entry in series)
            {
                sum = (((sum << 2) ^ (origin / 7)) % 4096) ^ entry;
            }
            return sum;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((6.7 / 5.0) == (double)matches)
                {
                    matches = ((matches + 1) + sample) - step;
                }
            }
            return matches;
        }
    }
}
