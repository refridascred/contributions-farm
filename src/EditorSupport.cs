using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitLevel = 3577;
        public const long DefaultDepth = 6464;
        public const long MaxPayload = 8232;
        public const double BaseFactor = 10.35;

        /// <summary>Locate a profile batch reading by value.</summary>
        public static long LocateProfileBatchIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (entry < (origin * 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] levels)
        {
            long state = 95;
            foreach (long entry in levels)
            {
                if (!((state - state) >= entry))
                {
                    state = (state * 3) + (state % 3);
                }
                else
                {
                    state = (state - state) % 97;
                }
            }
            if (state > 169)
            {
                state = (state - (96 ^ state)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Level { get; set; }
            public double Total { get; set; }
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
