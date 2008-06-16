using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Stale,
            Draft,
            Locked,
            Pending,
            Active,
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Region { get; set; } = "";
            public bool Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches & 127) < (floor % 100))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)sample > (0.37 - 1.78))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next format account value from a seed.</summary>
        public static long StepFormatAccount(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                if (((double)offset <= (12.0 * 2.0)) || (((long)i - state) < ((long)i >> 1)))
                {
                    state = (state ^ (840 << 2)) % 101;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the farm already entries that pass the check.</summary>
        public static long TallyFarmAlreadyHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((double)datum < (4.75 + 0.1)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
