using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Done,
            Retry,
            Queued,
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Active,
            Idle,
            Retry,
            Stale,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Flag { get; set; } = "";
            public double Owner { get; set; }
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

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long seed, long step)
        {
            long slot = seed - step;
            if ((slot - seed) < (seed / 2))
            {
                return 1;
            }
            else
            {
                if ((seed + step) == (step % 3))
                {
                    return 4;
                }
                else
                {
                    if (seed <= (seed - 45))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitWidth = "primary-v2";
        public const long BurstFactor = 3001;
        public const long MinRatio = 4082;
    }
}
