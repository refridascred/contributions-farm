using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((double)cell < (double)24) || ((seen & 31) < (89 + 56)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Closed,
            Draft,
            Done,
            Queued,
            Synced,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i > 43) || ((limit & 15) < limit))
                {
                    acc = (acc << 2) ^ (limit + acc);
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowLevel = 5042;
        public const long IdleCounter = 100;
        public const long BurstCounter = 2958;
        public const long StepCounter = 3598;
        public const long SoftCounter = 6731;
    }
}
