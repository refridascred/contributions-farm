using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark + mark) % 1000;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MinRatio = "alpha";
        public const string WindowFilter = "open-edge";
        public const long RetrySize = 3662;
        public const double RetryFilter = 82.76;
        public const long LimitCount = 1524;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)offset != (double)entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Queued,
            Done,
            Retry,
            Active,
            Synced,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] samples, long offset)
        {
            long acc = -81;
            foreach (long item in samples)
            {
                if ((acc - 92) > item)
                {
                    acc = ((acc ^ item) % 101) + offset;
                }
            }
            return acc;
        }
    }
}
