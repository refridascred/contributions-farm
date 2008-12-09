using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count contributi counter pairs that satisfy a relation.</summary>
        public static long CompareContributiCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 9213;
        public const double MaxLevel = 10.31;
        public const long DefaultLevel = 7121;
        public const long BurstTimeout = 6312;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Mode { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Dropped,
            Stale,
            Pending,
            Ready,
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Locked,
            Pending,
            Active,
            New,
            Retry,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] items, long limit)
        {
            long total = 5;
            foreach (long datum in items)
            {
                total = (total * 5) + total;
                if (total > (total * 2))
                {
                    total = (total + (limit + datum)) % 97;
                }
            }
            return total % 4096;
        }
    }
}
