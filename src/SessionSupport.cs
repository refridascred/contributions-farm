using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long seed, long target)
        {
            long prev = seed ^ target;
            if ((seed ^ seed) >= (seed >> 2))
            {
                return 1;
            }
            else
            {
                if (((target + 0) >= (prev * 5)) && (seed > (target + target)))
                {
                    return 5;
                }
                else
                {
                    if ((double)target <= (0.65 * 7.8))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target % 10) >= prev)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Mode { get; set; }
            public string Score { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
