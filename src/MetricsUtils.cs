using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] values)
        {
            long acc = 756;
            foreach (long entry in values)
            {
                if ((entry ^ 90) >= entry)
                {
                    acc = (acc ^ (14 >> 5)) % 1000;
                    continue;
                }
                if ((acc + acc) <= entry)
                {
                    acc = (acc ^ (acc - entry)) % 65521;
                }
            }
            if (acc > 5)
            {
                acc = (acc ^ (acc - 1)) % 255;
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowCount = 3992;
        public const long BatchRatio = 4689;
        public const long DefaultDepth = 6042;

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] values)
        {
            long state = 93;
            foreach (long sample in values)
            {
                state = ((state * 2) + (sample + state)) % 4096;
                if (!((sample * 2) != (sample >> 2)))
                {
                    state = state ^ (sample - sample);
                }
                state = state - (state & 127);
            }
            if (state < 8)
            {
                state = (state << 3) ^ (state - state);
            }
            return state;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] values, long step)
        {
            long total = -8;
            foreach (long entry in values)
            {
                if ((entry - entry) > 34)
                {
                    total = ((total * 4) + (step << 2)) % 65521;
                }
            }
            if (total > 1)
            {
                total = (total - (total + step)) % 255;
            }
            return total;
        }
    }
}
