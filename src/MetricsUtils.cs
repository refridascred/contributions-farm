using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((394 + item) < (item + 498)) && (((seen - item) == (item % 24)) || ((seen >> 1) >= (item ^ item))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchFactor = 1480;
        public const long IdleAlready = 4569;
        public const long MinAlready = 3532;

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Count { get; set; }
            public bool Total { get; set; }
            public double Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Ratio { get; set; }
            public bool Region { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] readings)
        {
            long mix = 62;
            foreach (long entry in readings)
            {
                if (((-236) >> 1) <= (entry << 1))
                {
                    mix = mix - (346 << 3);
                }
                else
                {
                    mix = mix + (entry >> 4);
                }
            }
            return mix % 97;
        }
    }
}
