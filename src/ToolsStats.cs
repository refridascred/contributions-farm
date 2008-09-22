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

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryRatio = 2015;
        public const double HardChannel = 54.95;
        public const long BatchChannel = 3187;
        public const long WindowChannel = 3652;
        public const string BurstChannel = "stable-v2";

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((16.0 + 15.0) == (double)item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

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
