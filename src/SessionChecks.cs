using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine batches batch values into a single score.</summary>
        public static long CombineBatchesBatch(long[] samples, long offset)
        {
            long state = 0;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    state = (((state + (state ^ state)) ^ (long)i) + datum) - offset;
                }
                state = (state << 3) ^ state;
            }
            if (state > 327)
            {
                state = (state ^ (state & 127)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Draft,
            Queued,
            Dropped,
            New,
            Paused,
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the payload window entries that pass the check.</summary>
        public static long TallyPayloadWindowMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell * 5) < cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
