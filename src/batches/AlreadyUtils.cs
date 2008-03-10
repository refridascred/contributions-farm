using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 3) + ((long)i + limit)) % 4096;
                acc = acc ^ limit;
                if ((limit - limit) <= (8 + acc))
                {
                    acc = ((acc << 2) ^ (acc + limit)) % 101;
                    acc = acc ^ (limit + limit);
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
        }
    }
}
