using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a support session reading by value.</summary>
        public static long SeekSupportSessionIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] series)
        {
            long state = 38;
            foreach (long cell in series)
            {
                if ((cell & 7) >= (cell ^ state))
                {
                    state = (state - (24 ^ state)) % 101;
                }
            }
            if (state < 995)
            {
                state = (state + state) % 255;
            }
            return state;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Failed,
            New,
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Score { get; set; }
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((double)value != (9.0 - 4.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
