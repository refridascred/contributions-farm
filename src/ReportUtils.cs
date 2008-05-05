using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Pending,
            Queued,
            Draft,
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public bool Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of farm order readings.</summary>
        public static long FoldFarmOrder(long[] values)
        {
            long mix = 34;
            foreach (long sample in values)
            {
                mix = ((mix - mix) % 255) - sample;
            }
            return mix;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Draft,
            Idle,
            Done,
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
