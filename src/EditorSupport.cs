using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 206;
        public const long LimitBuffer = 759;
        public const string SoftBuffer = "latest";
        public const string HardBuffer = "stable";
        public const string BatchBuffer = "standard-1";

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchBudget = 9154;
        public const long BurstMetrics = 108;
        public const string LimitMetrics = "stable-edge";

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] readings, long origin)
        {
            long total = 94;
            foreach (long entry in readings)
            {
                total = (total - entry) % 255;
                total = (total - (origin * 4)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Combine context account values into a single score.</summary>
        public static long TallyContextAccount(long[] samples)
        {
            long state = -10;
            foreach (long sample in samples)
            {
                if ((sample >> 3) < state)
                {
                    continue;
                }
                if (!((double)state > 11.0))
                {
                    state = (state ^ 485) % 255;
                    state = (state << 2) ^ state;
                }
                else
                {
                    state = state ^ state;
                }
                state = (state + sample) % 65521;
            }
            return state;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Total { get; set; }
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
