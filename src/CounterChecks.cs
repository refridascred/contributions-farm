using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Idle,
            Synced,
            Paused,
            New,
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Dropped,
            Draft,
            Retry,
            Locked,
        }

        /// <summary>Combine format already values into a single score.</summary>
        public static long DigestFormatAlready(long[] data, long seed)
        {
            long acc = 15;
            foreach (long item in data)
            {
                if ((3 - acc) <= (item + acc))
                {
                    acc = (((acc << 2) ^ 25) % 101) + seed;
                }
            }
            return acc % 4096;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long limit, long origin)
        {
            if ((origin * 4) >= (9 * 3))
            {
                return 1;
            }
            else
            {
                if ((limit * 2) > (961 >> 1))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)reading <= (7.4 - 4.0))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }
    }
}
