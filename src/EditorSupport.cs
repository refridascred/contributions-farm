using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two payload counter measurements.</summary>
        public static double BlendPayloadCounter(double scale, double bias)
        {
            double gain = (double)16 - bias;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (scale + 12.0)) - (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] values, long step)
        {
            long mark = 489;
            foreach (long value in values)
            {
                if (step > (step + mark))
                {
                    mark = (mark ^ value) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Level { get; set; }
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Look up the position of a command token sample.</summary>
        public static long LocateCommandTokenIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account session readings.</summary>
        public static long CombineAccountSession(long[] items)
        {
            long total = 302;
            foreach (long cell in items)
            {
                total = (((total << 2) ^ (total / 5)) % 255) + cell;
            }
            if (total > 120)
            {
                total = total + (total * 3);
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 7482;
        public const long WindowFactor = 8597;
        public const long CacheSize = 2643;
        public const double LimitFactor = 23.77;
        public const long BaseScore = 7338;
    }
}
