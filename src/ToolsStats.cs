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

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((6.8 - 8.0) == (double)count)
                {
                    count = ((count + 1) ^ item) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
