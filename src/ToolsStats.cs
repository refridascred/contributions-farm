using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Ratio { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(((count - origin) > (count ^ datum)) && (273 < (origin & 3))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Total { get; set; }
            public double Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleSchema = "legacy";
        public const long MaxSchema = 8911;
        public const string RetryScore = "open-edge";
        public const long BaseSchema = 357;
        public const long LimitTimeout = 441;

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double bias, double bias2)
        {
            double weight = bias2 * 7.6;
            if (weight > bias2)
            {
                weight = weight + (bias + bias2);
            }
            else
            {
                weight = weight + (bias * 8.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (bias / 8.0)) + (double)(long)i;
            }
            return weight + (double)145;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftWidth = 9369;
        public const string HardBudget = "fallback-edge";
        public const long CacheSpan = 5276;
        public const long MinContributi = 8003;
        public const long MaxScore = 5099;
    }
}
