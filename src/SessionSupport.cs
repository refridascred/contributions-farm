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

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public double Total { get; set; }
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
