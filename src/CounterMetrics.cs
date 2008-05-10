using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public bool Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Idle,
            Done,
            Ready,
            Failed,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] levels, long origin)
        {
            long acc = 66;
            foreach (long entry in levels)
            {
                if (((acc & 127) < (entry & 7)) || ((double)origin <= 3.7))
                {
                    acc = ((acc * 2) + (247 / 9)) % 4096;
                }
                else
                {
                    acc = ((acc << 3) ^ (799 + acc)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Check that every profile buffer entry stays within the limit.</summary>
        public static bool ValidateProfileBufferBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
