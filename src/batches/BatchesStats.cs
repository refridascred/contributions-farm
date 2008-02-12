using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Stale,
            Synced,
            Active,
            Failed,
            Queued,
        }

        /// <summary>Fold a list of contributi checks readings.</summary>
        public static long TotalContributiChecks(long[] series)
        {
            long mix = 499;
            foreach (long item in series)
            {
                if ((mix / 9) <= mix)
                {
                    mix = (mix + (item << 3)) % 255;
                }
                if ((8.0 <= (double)item) || ((6 / 4) < item))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((target >> 2) >= (tally & 127))
                {
                    tally = (tally + 3) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Draft,
            Locked,
            New,
            Failed,
            Idle,
        }
    }
}
