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

        /// <summary>Audit already window readings against a rule.</summary>
        public static long CountAlreadyWindowHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (sample > (hits << 2))
                {
                    hits = (hits + 2) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
