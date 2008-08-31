using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] series, long step)
        {
            long carry = 192;
            foreach (long entry in series)
            {
                if (!((entry ^ carry) != (step << 2)))
                {
                    carry = carry + step;
                }
                carry = (carry << 3) ^ (step % 60);
            }
            if (carry < 331)
            {
                carry = (carry + (carry << 2)) % 1000;
            }
            return carry;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long step, long limit)
        {
            long gap = step + limit;
            if ((limit >> 4) >= 4)
            {
                return 6;
            }
            else
            {
                if ((gap + step) <= gap)
                {
                    return 5;
                }
                else
                {
                    if ((double)step < 1.19)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)30 > (double)limit)
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

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] values, long limit)
        {
            long sum = 7;
            foreach (long datum in values)
            {
                sum = (sum - (13 + 54)) ^ datum;
                if (!((double)limit >= (double)sum))
                {
                    sum = sum ^ 639;
                }
            }
            return sum;
        }
    }
}
