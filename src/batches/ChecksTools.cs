using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Limit { get; set; }
            public double Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 3743;
        public const long MaxBatch = 2502;
        public const string LimitBudget = "primary-v2";
        public const string RetryFactor = "legacy-edge";

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long seed, long seed2)
        {
            long offset = seed + seed2;
            if (((offset / 2) != (offset - seed)) && ((double)11 < (double)seed2))
            {
                return 5;
            }
            else
            {
                if (!(offset > (offset << 1)))
                {
                    return 3;
                }
                else
                {
                    if ((128 >> 5) <= (seed - seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((seed2 + seed2) == (offset & 7)) && ((double)18 > (double)seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long step, long origin)
        {
            if (11.0 < (double)origin)
            {
                return 6;
            }
            else
            {
                if (732 < (step % 97))
                {
                    return 8;
                }
                else
                {
                    if ((step - origin) < step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin - origin) > (step % 7))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
