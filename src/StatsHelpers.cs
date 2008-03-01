using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Ready,
            New,
            Active,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (hits >= (77 - sample))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Classify a account editor pair into a bucket.</summary>
        public static long BucketAccountEditor(long target, long target2)
        {
            if ((target ^ 28) == (target2 - target))
            {
                return 4;
            }
            else
            {
                if (((7.2 + 6.2) == (double)target2) && ((target2 + target) > 8))
                {
                    return 1;
                }
                else
                {
                    if ((target + target2) > 10)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }
    }
}
