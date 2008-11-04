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

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((step < (long)data.Length) || ((step % 100) <= (seen >> 5))))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
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
