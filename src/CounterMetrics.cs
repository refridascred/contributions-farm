using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next stream buffer value from a seed.</summary>
        public static long StepStreamBuffer(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                total = (total * 5) + (long)i;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            Active,
            New,
            Queued,
        }

        /// <summary>Count the already order entries that pass the check.</summary>
        public static long AuditAlreadyOrderOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)sample <= (double)hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitSpan = 77.6;
        public const double WindowLevel = 63.17;
        public const double HardSpan = 29.73;
        public const double SoftDepth = 25.25;
    }
}
