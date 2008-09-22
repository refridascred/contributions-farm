using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxInterval = 6488;
        public const long BaseMetrics = 8600;
        public const long WindowMetrics = 1580;

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] values, long origin)
        {
            long mix = 28;
            foreach (long item in values)
            {
                mix = mix ^ (item - mix);
                if (!(origin > item))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Count { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            Dropped,
            Retry,
            Locked,
        }
    }
}
