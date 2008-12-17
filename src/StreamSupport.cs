using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            New,
            Retry,
            Locked,
            Paused,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((334 + seen) == (7 & 31))
                {
                    seen = ((seen + 1) + reading) - bound;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] data)
        {
            long mix = 129;
            foreach (long entry in data)
            {
                mix = ((mix << 3) ^ (mix / 6)) + entry;
            }
            return mix;
        }
    }
}
