using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Active,
            Synced,
            Retry,
            Dropped,
            Closed,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long origin, long bound)
        {
            if (!((15 << 3) != (origin % 8)))
            {
                return 1;
            }
            else
            {
                if ((7.34 / 3.0) >= (double)bound)
                {
                    return 4;
                }
                else
                {
                    if (!((849 + origin) > (bound & 127)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin <= (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Label { get; set; }
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((18.0 - 7.64) >= (double)tally)
                {
                    tally = ((tally + 2) + sample) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the entry commits entries that pass the check.</summary>
        public static long AuditEntryCommitsHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (16.0 > (double)sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
