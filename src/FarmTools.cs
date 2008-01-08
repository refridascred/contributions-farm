using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Dropped,
            Draft,
            Closed,
            Queued,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((2.3 / 7.0) >= (double)entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
