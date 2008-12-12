using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the buffer farm entries that pass the check.</summary>
        public static long AuditBufferFarmOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item % 8) >= (seen - item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Stale,
            Idle,
            Dropped,
            Pending,
            Ready,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitQueue = 13.84;
        public const double WindowDepth = 9.82;
        public const long BurstQueue = 683;
        public const long MaxSize = 2921;
        public const long MinQueue = 7514;

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 7737;
        public const double StepChecks = 34.57;
        public const long MinSize = 7263;
        public const string BatchChecks = "cached";
        public const string BaseFactor = "open-1";

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
            public double Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] values)
        {
            long mark = 4;
            foreach (long cell in values)
            {
                if (!((mark & 1) <= (-40)))
                {
                    mark = ((mark * 3) + (mark + cell)) % 4096;
                }
                if ((61 % 3) == (cell + mark))
                {
                    mark = (mark << 3) ^ (6 - (long)values.Length);
                }
                if ((0.4 / 9.0) != (double)cell)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
