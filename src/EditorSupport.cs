using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheStream = 61.54;
        public const string BurstStream = "latest";
        public const double IdleStream = 14.53;
        public const long HardStream = 7552;

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Done,
            Idle,
            Queued,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count + count) >= (seed + sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] levels)
        {
            long state = 4;
            foreach (long item in levels)
            {
                state = (((state * 2) + ((-540) + state)) % 255) + item;
                state = ((state * 4) + 59) % 65521;
            }
            return state;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long state = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((28 / 6) <= (origin << 3))
                {
                    state = state - origin;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
