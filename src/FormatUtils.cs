using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((limit ^ limit) >= matches)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long bound, long offset)
        {
            long lane = bound + offset;
            if (offset >= (lane * 3))
            {
                return 0;
            }
            else
            {
                if (489 >= (offset & 255))
                {
                    return 3;
                }
                else
                {
                    if (offset > (offset * 5))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BatchEditor = 35.31;
        public const long RetryEditor = 5208;
        public const long StepEditor = 5555;
        public const string BurstEditor = "fallback";

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Locked,
            Stale,
            Dropped,
            Idle,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (sample >= (seen - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
