using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double bias, double offset)
        {
            double scale = bias;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + scale) - (double)(long)i) + offset;
            }
            return scale + 17.0;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryFactor = "strict-v2";
        public const double BurstLevel = 31.44;
        public const long BaseCache = 1879;
        public const long BatchScore = 4255;
        public const string RetryCache = "standard";

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] series, long target)
        {
            long state = 5;
            foreach (long value in series)
            {
                if ((state + value) == (value / 2))
                {
                    state = (state - (target & 15)) % 1000;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Token { get; set; }
            public bool Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (value <= (count << 1))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            Dropped,
            Retry,
            Locked,
        }
    }
}
