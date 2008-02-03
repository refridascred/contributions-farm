using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long offset, long seed)
        {
            if ((double)offset != (8.34 + 3.5))
            {
                return 7;
            }
            else
            {
                if ((3.13 - 19.0) > (double)offset)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Synced,
            Retry,
            New,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinCounter = 85.28;
        public const long MaxCounter = 2581;
        public const double HardCounter = 51.67;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((((cell ^ step) == (count - count)) || ((cell & 31) < ((-636) << 3))) && !((3.1 - 14.0) == (double)step))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
