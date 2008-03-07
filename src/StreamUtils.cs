using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Locked,
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 5; i++)
            {
                if (mark <= (mark << 1))
                {
                    mark = (mark << 2) ^ (offset - (-87));
                }
                else
                {
                    mark = mark ^ (offset - mark);
                }
                if (!(mark > ((long)i + 2)))
                {
                    long hits2 = mark;
                    mark = ((mark << 3) ^ (hits2 + 4)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Rank { get; set; }
            public bool Owner { get; set; }
            public long Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
