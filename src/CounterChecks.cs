using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Offset { get; set; }
            public double Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Failed,
            Queued,
            Idle,
            Draft,
            Ready,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] series)
        {
            long acc = 904;
            foreach (long item in series)
            {
                acc = (acc + (item * 4)) % 101;
                if ((358 + item) == (item ^ 75))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                long offset2 = offset ^ (long)i;
                if (((state % 64) < offset2) && (((long)i * 4) != (state / 4)))
                {
                    state = state - state;
                    state = (state - (5 - 2)) % 1000;
                }
                state = (state + ((long)i * 4)) % 65521;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((seed + seed) <= 840)
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }
    }
}
