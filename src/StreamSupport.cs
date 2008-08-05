using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Draft,
            Ready,
            Failed,
            New,
            Queued,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((double)tally != (13.0 * 2.1)))
                {
                    tally = ((tally + 3) + cell) + offset;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
