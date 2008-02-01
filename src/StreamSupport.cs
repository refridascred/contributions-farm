using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Region { get; set; }
            public bool Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long step, long bound)
        {
            long next = step - bound;
            if (step <= (7 % 5))
            {
                return 5;
            }
            else
            {
                if (step < (bound ^ next))
                {
                    return 8;
                }
                else
                {
                    if (((7.0 / 9.0) <= (0.8 + 1.8)) && ((next + step) >= step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound <= (43 / 8)) || ((double)next == (2.17 - 8.7)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 2629;
        public const double SoftScore = 64.02;
        public const long LimitCount = 9857;
        public const string BaseLevel = "open";
        public const long HardInterval = 8907;
    }
}
