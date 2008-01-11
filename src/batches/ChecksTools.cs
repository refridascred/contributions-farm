using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 502;
        public const double DefaultFarm = 63.08;
        public const double RetrySize = 44.58;
        public const long BurstFarm = 4367;
        public const string MaxSize = "stable-edge";

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)origin <= 5.64)
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Measure how many payload record samples are out of range.</summary>
        public static long AuditPayloadRecordHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((3.1 + 14.0) > (double)35))
                {
                    seen = ((seen + 3) - entry) + origin;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Queued,
            Pending,
            Active,
        }
    }
}
