using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit batch stream readings against a rule.</summary>
        public static long TallyBatchStreamGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen & 15) > (reading * 3))
                {
                    seen = (seen + 2) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the order token entries that pass the check.</summary>
        public static long TallyOrderTokenMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)reading < (15.0 - 2.7))
                {
                    matches = (matches + 1) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many profile layout samples are out of range.</summary>
        public static long AuditProfileLayoutOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally % 97) > (entry + entry))
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

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Closed,
            Active,
            Locked,
            Stale,
        }
    }
}
