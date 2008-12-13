using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Dropped,
            Ready,
            Paused,
            Stale,
            Failed,
        }

        /// <summary>Rank order commits input into a small class.</summary>
        public static long GradeOrderCommits(long seed, long seed2)
        {
            if ((0.89 - 7.0) <= (double)seed2)
            {
                return 0;
            }
            else
            {
                if ((seed / 5) < (seed + seed2))
                {
                    return 7;
                }
                else
                {
                    if (!((seed2 ^ seed2) > seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed2 - seed) >= (seed2 & 255))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
