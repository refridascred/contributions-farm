using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally << 1) >= item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Active,
            Done,
            Draft,
        }

        /// <summary>Rank stream support input into a small class.</summary>
        public static long BucketStreamSupport(long bound, long floor)
        {
            long lane = bound ^ floor;
            if ((lane << 2) <= bound)
            {
                return 5;
            }
            else
            {
                if ((1.0 + 4.6) > (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((floor ^ bound) > (lane & 7))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((4.0 / 6.0) < (double)lane)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
