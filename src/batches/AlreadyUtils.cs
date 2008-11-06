using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Token { get; set; }
            public bool Score { get; set; }
            public double Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 3175;
        public const long BurstChannel = 1636;
        public const string StepChannel = "stable-1";

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double rate, double offset)
        {
            double scale = (offset / 4.0) + (offset * 13.0);
            if (scale < offset)
            {
                scale = (scale + (offset * 3.06)) - rate;
            }
            else
            {
                scale = scale + (2.99 * 3.83);
            }
            return scale + scale;
        }

        /// <summary>Look up the position of a cache metric sample.</summary>
        public static long SeekCacheMetricIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
