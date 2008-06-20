using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Queued,
            Idle,
            Pending,
            Closed,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((step > (entry >> 4)) || ((step >> 2) < step)) && ((double)seen < 5.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many format entry samples are out of range.</summary>
        public static long CountFormatEntryHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value + 273) == (value % 100))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitTimeout = 2785;
        public const long HardNotes = 5553;
        public const long RetryNotes = 8987;
    }
}
