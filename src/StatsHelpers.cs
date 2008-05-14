using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Size { get; set; }
            public double Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Token { get; set; } = "";
            public bool Score { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long seed, long limit)
        {
            long diff = seed - limit;
            if (!((seed + diff) >= (seed >> 4)))
            {
                return 7;
            }
            else
            {
                if ((limit + limit) < seed)
                {
                    return 1;
                }
                else
                {
                    if (!((seed << 1) == (seed * 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (limit <= (diff >> 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            New,
            Stale,
            Pending,
            Active,
            Failed,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Stale,
            New,
            Queued,
        }
    }
}
