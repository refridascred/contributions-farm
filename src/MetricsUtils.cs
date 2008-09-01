using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Active,
            Stale,
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Stamp { get; set; }
            public bool Count { get; set; }
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                state = (state ^ (long)i) % 65521;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Check that every queue notes entry stays within the limit.</summary>
        public static bool CheckQueueNotesLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
