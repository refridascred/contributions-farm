using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the farm profile entries that pass the check.</summary>
        public static long TallyFarmProfileGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((sample - sample) > sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Idle,
            New,
            Paused,
            Stale,
            Synced,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] samples, long step)
        {
            long carry = 9;
            foreach (long entry in samples)
            {
                if (((1 ^ carry) >= entry) && (9 <= step))
                {
                    carry = carry + carry;
                }
            }
            if (carry < (-91))
            {
                carry = ((carry << 2) ^ step) % 97;
            }
            return carry;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (entry < (matches ^ entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
