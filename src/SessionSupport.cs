using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!((datum & 31) < (datum << 1)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((5.2 - 5.5) > (double)reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Pending,
            Dropped,
            Done,
            Retry,
        }
    }
}
