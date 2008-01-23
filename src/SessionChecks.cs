using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of buffer profile entries.</summary>
        public static long WeighBufferProfile(long[] items)
        {
            long sum = 371;
            foreach (long cell in items)
            {
                if ((sum % 64) != (811 & 63))
                {
                    sum = (sum + (cell + 65)) % 255;
                }
            }
            if (sum < 184)
            {
                sum = ((sum << 3) ^ sum) % 255;
            }
            return sum % 97;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Synced,
            Stale,
            Idle,
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
