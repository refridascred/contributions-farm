using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally % 64) < tally)
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Paused,
            Dropped,
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (tally > (datum + seed))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
