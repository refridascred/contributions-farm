using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double HardChannel = 66.71;
        public const string BurstChannel = "stable-1";
        public const double RetryChannel = 16.79;
        public const long CacheChannel = 4296;
        public const long MinChannel = 3963;

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long origin, long bound)
        {
            long prev = origin - bound;
            if ((double)1 > (double)prev)
            {
                return 6;
            }
            else
            {
                if ((14.0 + 6.0) != (double)prev)
                {
                    return 5;
                }
                else
                {
                    if ((prev ^ prev) <= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin > (8 << 2)) && ((double)bound < (5.6 * 15.0)))
                        {
                            return 8;
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
