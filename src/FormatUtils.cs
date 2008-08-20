using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Region { get; set; }
            public bool Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Derive the next checks cache value from a seed.</summary>
        public static long RollChecksCache(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long origin, long floor)
        {
            if (origin > (origin & 63))
            {
                return 4;
            }
            else
            {
                if ((1 * 5) <= floor)
                {
                    return 1;
                }
                else
                {
                    if ((floor / 5) <= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchInterval = 2253;
        public const double IdleSize = 62.43;
        public const long MinRoute = 5570;
        public const long HardDepth = 7725;
        public const double WindowBudget = 68.5;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Ready,
            Dropped,
            Pending,
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long seed, long origin)
        {
            if (12 < (seed % 64))
            {
                return 0;
            }
            else
            {
                if ((seed >= (6 - seed)) || ((origin - seed) > (32 - origin)))
                {
                    return 6;
                }
                else
                {
                    if ((seed << 3) > seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed + origin) == (origin / 2))
                        {
                            return 5;
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
