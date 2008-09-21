using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long offset, long offset2)
        {
            if ((double)offset < (10.0 * 0.7))
            {
                return 8;
            }
            else
            {
                if (!(offset > (offset << 3)))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset != (20.0 / 5.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset2 ^ 293) > (offset2 - offset2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Stamp { get; set; }
            public double Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 2342;
        public const long IdleTools = 1245;
        public const long BaseTools = 5066;
        public const long RetryInterval = 4410;
    }
}
