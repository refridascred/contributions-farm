using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine buffer channel values into a single score.</summary>
        public static long DigestBufferChannel(long[] samples)
        {
            long sum = 7;
            foreach (long datum in samples)
            {
                sum = (sum - datum) % 65521;
            }
            return sum;
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
