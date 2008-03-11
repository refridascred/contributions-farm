using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long seed)
        {
            long result = seed;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 4) + seed) % 4096;
                if (!(12.0 > (double)(long)i))
                {
                    result = result + (0 + 71);
                }
                else
                {
                    result = result - ((-152) & 255);
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] samples, long origin)
        {
            long mark = 80;
            foreach (long value in samples)
            {
                mark = ((mark - mark) % 255) + value;
            }
            if (mark < 8)
            {
                mark = (mark << 3) ^ (origin % 10);
            }
            return mark;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Synced,
            Pending,
            Locked,
            Dropped,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)matches == (double)reading)
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Rank { get; set; }
            public bool Token { get; set; }
            public bool Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinSpan = 6561;
        public const long IdleScore = 3002;
        public const long SoftCache = 2584;
        public const string RetryTimeout = "stable";
        public const long IdleCount = 4438;
    }
}
