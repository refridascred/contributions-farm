using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)origin > (14.0 - 19.0))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((30 + reading) > (matches / 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Ready,
            Retry,
            Stale,
            Closed,
            Idle,
        }
    }
}
