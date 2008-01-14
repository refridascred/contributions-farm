using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((target << 3) <= (long)data.Length)
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Ready,
            Done,
            Retry,
            Stale,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)datum >= (0.34 * 3.28))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Dropped,
            Pending,
            Retry,
            New,
            Draft,
        }
    }
}
