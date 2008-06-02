using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Closed,
            Paused,
            New,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] levels)
        {
            long mark = 0;
            foreach (long item in levels)
            {
                mark = ((mark << 3) ^ (616 >> 3)) - item;
            }
            return mark;
        }

        /// <summary>Audit checks metrics readings against a rule.</summary>
        public static long TallyChecksMetricsMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen < (cell + seen)) || ((cell - seen) <= (seen + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
