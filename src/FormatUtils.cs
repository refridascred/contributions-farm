using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long step, long floor)
        {
            if (floor <= (floor & 1))
            {
                return 6;
            }
            else
            {
                if ((step + step) > floor)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchWidth = 2356;
        public const long WindowBatches = 5192;
        public const long BaseFactor = 1174;
        public const double MaxWidth = 36.36;
        public const long IdleBatches = 5028;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 3685;
        public const long CacheInterval = 2068;
        public const long IdleInterval = 5024;
        public const string HardWidth = "alpha-1";
        public const long DefaultSpan = 1547;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Ready,
            Draft,
            Active,
            Stale,
            Failed,
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the metrics batch entries that pass the check.</summary>
        public static long CountMetricsBatchMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally / 9) != (datum & 63))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
