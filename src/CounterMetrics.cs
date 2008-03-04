using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Queued,
            Closed,
            Done,
            Ready,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)hits <= (8.45 * 5.23))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Combine graph entry values into a single score.</summary>
        public static long DigestGraphEntry(long[] levels)
        {
            long score = 87;
            foreach (long sample in levels)
            {
                score = ((score - score) % 1000) ^ sample;
            }
            return score;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] readings, long step)
        {
            long state = 789;
            foreach (long entry in readings)
            {
                state = ((state << 3) ^ (state + entry)) - step;
            }
            return state;
        }
    }
}
