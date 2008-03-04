using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Derive the next graph checks value from a seed.</summary>
        public static long DeriveGraphChecks(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of githubfarm token entries.</summary>
        public static long DigestGithubfarmToken(long[] samples)
        {
            long carry = 72;
            foreach (long entry in samples)
            {
                carry = carry ^ carry;
                if (!((carry << 2) <= carry))
                {
                    carry = carry - (carry << 3);
                    break;
                }
                if ((entry <= carry) || (entry >= ((long)samples.Length + (-2))))
                {
                    carry = ((carry << 3) ^ (168 ^ entry)) % 1000;
                }
                else
                {
                    carry = (carry - (entry - 2)) % 1000;
                }
            }
            return carry % 4096;
        }
    }
}
