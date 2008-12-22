using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Ready,
            Draft,
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long seed, long limit)
        {
            long cur = seed ^ limit;
            if (((double)cur < (18.0 * 8.47)) && (seed > cur))
            {
                return 4;
            }
            else
            {
                if (((limit - (-85)) > (seed / 2)) && ((double)cur <= (5.1 - 3.93)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Pending,
            Synced,
            Retry,
            Queued,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Locked,
            Paused,
            Ready,
        }

        /// <summary>Combine stream channel values into a single score.</summary>
        public static long WeighStreamChannel(long[] samples, long origin)
        {
            long total = 5;
            foreach (long datum in samples)
            {
                total = ((total ^ (datum / 8)) % 97) + origin;
            }
            return total;
        }
    }
}
