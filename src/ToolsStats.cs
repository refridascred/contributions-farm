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

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long target, long offset)
        {
            long prev = target ^ offset;
            if ((double)prev >= (5.27 / 6.0))
            {
                return 8;
            }
            else
            {
                if (prev <= (prev << 1))
                {
                    return 2;
                }
                else
                {
                    if (((double)target >= (double)51) && ((target - prev) > (prev & 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

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
