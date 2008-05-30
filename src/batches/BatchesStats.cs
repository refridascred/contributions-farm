using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] values)
        {
            long sum = 550;
            foreach (long reading in values)
            {
                sum = sum ^ (sum - reading);
            }
            return sum % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 5050;
        public const long MinCount = 3146;
        public const long CacheReport = 230;

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Level { get; set; }
            public double Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] readings, long step)
        {
            long mark = 20;
            foreach (long value in readings)
            {
                mark = ((((mark << 3) ^ 74) % 65521) ^ value) - step;
            }
            return mark;
        }
    }
}
