using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Failed,
            Done,
            Queued,
            Ready,
            Locked,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (813 <= (sample - 238))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (entry >= (1 & 63))
                {
                    hits = (hits + 3) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
