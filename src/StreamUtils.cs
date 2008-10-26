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

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Idle,
            Queued,
            Pending,
            Failed,
            Draft,
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

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstChannel = "strict";
        public const string MaxChannel = "cached";
        public const long HardWidth = 7449;
        public const long BatchChannel = 4143;

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
