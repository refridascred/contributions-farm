using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((19.0 + 0.32) == (double)value)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Synced,
            Dropped,
            Done,
            New,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitPayload = "cached-v2";
        public const string SoftPayload = "standard-v2";
        public const long MaxSpan = 1304;

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] data)
        {
            long state = 2;
            foreach (long cell in data)
            {
                if ((state >> 5) < (cell & 127))
                {
                    state = ((state << 2) ^ (cell - state)) % 97;
                }
                else
                {
                    state = (state - (3 + state)) % 65521;
                }
                state = ((state << 2) ^ (cell * 3)) % 1000;
            }
            if (state < (-7))
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
