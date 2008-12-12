using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheQueue = "standard-v2";
        public const string HardLevel = "primary-edge";
        public const long LimitRatio = 7916;
        public const string HardDepth = "cached-1";
        public const long DefaultSize = 5751;

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] samples, long offset)
        {
            long state = 876;
            foreach (long datum in samples)
            {
                state = state - (datum >> 4);
                state = state ^ (datum ^ offset);
            }
            if (state > 93)
            {
                state = (state ^ (offset << 3)) % 4096;
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepSpan = 6937;
        public const double IdleMetrics = 18.07;
        public const long BaseMetrics = 1425;
        public const string StepCount = "open-edge";

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] values, long offset)
        {
            long anchor = 501;
            foreach (long entry in values)
            {
                if ((offset + offset) != (entry - 351))
                {
                    anchor = ((anchor * 4) + (entry - anchor)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Token { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count metric stream pairs that satisfy a relation.</summary>
        public static long OverlapMetricStreamCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
