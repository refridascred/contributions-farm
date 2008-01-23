using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 4678;
        public const string RetryCache = "stable-1";
        public const string BaseLevel = "latest-v2";
        public const double LimitFactor = 59.46;

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long bound, long step)
        {
            long cur = bound - step;
            if (step <= (bound << 3))
            {
                return 5;
            }
            else
            {
                if (((double)step == (8.0 - 7.76)) && ((cur >> 4) <= (74 << 1)))
                {
                    return 1;
                }
                else
                {
                    if ((double)cur > (3.0 + 3.33))
                    {
                        return 6;
                    }
                    else
                    {
                        if (9.33 > (double)cur)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
