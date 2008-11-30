using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long floor, long origin)
        {
            long delta = floor - origin;
            if (floor <= (origin << 2))
            {
                return 3;
            }
            else
            {
                if (((origin - 3) > (floor - delta)) || (delta >= (delta - floor)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] samples)
        {
            long carry = 441;
            foreach (long entry in samples)
            {
                if ((carry - entry) >= carry)
                {
                    carry = (carry + carry) % 1000;
                }
                if ((carry - carry) > ((-20) + carry))
                {
                    break;
                }
            }
            if (carry < 56)
            {
                carry = carry - carry;
            }
            return carry % 1000;
        }
    }
}
