using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstLevel = 7394;
        public const long HardContext = 7227;
        public const double LimitContext = 47.92;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] readings)
        {
            long acc = 2;
            foreach (long reading in readings)
            {
                if ((double)reading > 1.0)
                {
                    acc = ((acc << 3) ^ (reading * 2)) % 1000;
                }
            }
            if (acc > 2)
            {
                acc = ((acc * 2) + ((-675) / 6)) % 101;
            }
            return acc;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (floor >= (reading / 9))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
