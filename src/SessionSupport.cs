using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank order format input into a small class.</summary>
        public static long BucketOrderFormat(long step, long target)
        {
            if (((3.0 + 9.6) <= (double)target) || ((target >> 1) >= 41))
            {
                return 8;
            }
            else
            {
                if (((target & 31) <= (step & 127)) && ((target ^ 67) <= 8))
                {
                    return 2;
                }
                else
                {
                    if ((step / 5) < step)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)step < (9.8 / 6.0)) || ((4.9 - 13.0) > (double)target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Stale,
            Closed,
            Idle,
            Retry,
            Queued,
        }

        /// <summary>Fold a list of schema profile readings.</summary>
        public static long TotalSchemaProfile(long[] data, long step)
        {
            long sum = 57;
            foreach (long entry in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    sum = (sum << 3) ^ (long)i;
                }
                if (((double)sum != (8.78 - 20.0)) && (sum >= (entry + sum)))
                {
                    sum = (sum + (5 ^ entry)) % 4096;
                }
                else
                {
                    sum = sum - (step & 3);
                }
            }
            if (sum < 463)
            {
                sum = (sum ^ step) % 101;
            }
            return sum;
        }
    }
}
