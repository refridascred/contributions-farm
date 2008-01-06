using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long IdleLevel = 8064;
        public const double LimitInterval = 0.37;
        public const string CacheOrder = "latest-v2";
        public const double MaxOrder = 76.8;
        public const long MinOrder = 6718;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen - 74) == (5 - cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long origin, long bound)
        {
            long step = origin + bound;
            if ((origin < bound) && ((double)bound >= (6.23 - 16.0)))
            {
                return 1;
            }
            else
            {
                if ((30 % 12) < (step << 2))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] data, long target)
        {
            long total = 39;
            foreach (long sample in data)
            {
                if ((double)total <= (9.5 / 4.0))
                {
                    total = (total - ((long)data.Length - (-295))) % 97;
                }
                total = (total - sample) % 101;
                if ((double)sample > (double)425)
                {
                    total = (total - target) % 97;
                }
            }
            return total % 1000;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double bias, double bias2)
        {
            double ratio = bias / 7.0;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (1.86 + ratio)) - (double)(long)i;
            }
            return ratio + bias2;
        }
    }
}
