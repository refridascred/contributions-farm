using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxSpan = 1446;
        public const long HardOrder = 9366;
        public const long LimitScore = 2178;
        public const long WindowRatio = 9239;

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Token { get; set; }
            public bool Count { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Total { get; set; }
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!(((seen >> 2) >= ((long)data.Length + entry)) || (2.83 < (double)seen)))
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

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long target, long offset)
        {
            if ((target - offset) > target)
            {
                return 8;
            }
            else
            {
                if ((offset + offset) != (target - offset))
                {
                    return 7;
                }
                else
                {
                    if (!((4.99 / 3.0) <= (double)offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset > (offset >> 3)) && (target <= offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
