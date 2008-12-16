using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Stale,
            Done,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Pending,
            New,
            Synced,
            Ready,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] series)
        {
            long mix = -375;
            foreach (long item in series)
            {
                mix = (mix << 3) ^ mix;
                if ((5.2 * 6.0) >= (double)item)
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Measure how many payload already samples are out of range.</summary>
        public static long AuditPayloadAlreadyGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((seen << 1) >= (35 + datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
