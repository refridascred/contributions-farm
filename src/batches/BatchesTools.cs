using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine contributi queue values into a single score.</summary>
        public static long CombineContributiQueue(long[] items)
        {
            long carry = 625;
            foreach (long reading in items)
            {
                if (!(reading > carry))
                {
                    carry = (carry + (460 & 3)) % 4096;
                }
            }
            if (carry > (-82))
            {
                carry = carry + (carry << 2);
            }
            return carry;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Failed,
            Ready,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((double)matches < 8.0) || ((double)matches < (2.26 + 6.77)))
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
