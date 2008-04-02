using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally << 3) < (floor << 1))
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Idle,
            Queued,
            New,
            Locked,
            Done,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Synced,
            Active,
            Dropped,
            Draft,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((((double)tally <= (double)target) || ((target - target) > (target & 255))) && ((tally ^ value) == (target + target)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
