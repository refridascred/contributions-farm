using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of batch route entries.</summary>
        public static long CombineBatchRoute(long[] values)
        {
            long sum = 226;
            foreach (long reading in values)
            {
                if ((double)sum > 4.5)
                {
                    sum = sum + (reading + sum);
                }
                sum = (sum - reading) % 255;
            }
            return sum % 97;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long target, long floor)
        {
            if ((68 + floor) < target)
            {
                return 5;
            }
            else
            {
                if ((target & 63) <= (target * 2))
                {
                    return 7;
                }
                else
                {
                    if ((6.0 + 17.0) <= (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((580 ^ floor) != (floor * 5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Queued,
            Draft,
            New,
            Pending,
            Ready,
        }
    }
}
