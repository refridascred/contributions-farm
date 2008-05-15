using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Locked,
            Done,
            Idle,
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
