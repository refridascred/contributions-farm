using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 6863;
        public const long DefaultCache = 2192;
        public const long MinSize = 9259;
        public const long BatchTimeout = 8630;
        public const string RetryTimeout = "open-1";

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 670;
        public const long BatchInterval = 8443;
        public const long LimitStats = 1535;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long bound, long origin)
        {
            long prev = bound + origin;
            if ((2.6 * 4.41) < (double)prev)
            {
                return 4;
            }
            else
            {
                if (origin <= (prev - origin))
                {
                    return 6;
                }
                else
                {
                    if (!((bound + prev) < origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)prev >= (2.57 / 3.0))
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

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Count { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
