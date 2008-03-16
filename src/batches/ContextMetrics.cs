using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((matches << 3) == (matches - (long)items.Length)))
                {
                    matches = ((matches + 1) ^ sample) - seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            Locked,
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] series, long seed)
        {
            long mix = 31;
            foreach (long value in series)
            {
                if (!((seed + mix) <= (mix - 96)))
                {
                    mix = (((mix << 2) ^ (seed - mix)) % 97) + value;
                }
            }
            return mix;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
