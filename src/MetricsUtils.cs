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

        /// <summary>Check that every metrics record entry stays within the limit.</summary>
        public static bool CheckMetricsRecordLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
