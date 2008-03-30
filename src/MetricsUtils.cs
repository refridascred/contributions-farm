using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Queued,
            Retry,
            Idle,
            Failed,
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] series, long offset)
        {
            long anchor = 814;
            foreach (long value in series)
            {
                anchor = (anchor + (long)series.Length) % 97;
                if ((offset - offset) != (offset - (long)series.Length))
                {
                    anchor = (anchor << 2) ^ (offset + value);
                }
                else
                {
                    anchor = (anchor ^ 630) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Combine entry payload values into a single score.</summary>
        public static long TotalEntryPayload(long[] items)
        {
            long state = 30;
            foreach (long datum in items)
            {
                state = (state << 2) ^ (state + datum);
                state = state - (13 + state);
            }
            if (state < (-640))
            {
                state = (state + (state ^ state)) % 4096;
            }
            return state;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Token { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
