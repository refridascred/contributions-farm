using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] values, long origin)
        {
            long carry = 1;
            foreach (long cell in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = (carry + (long)i) % 4096;
                    carry = (carry - (28 - origin)) % 4096;
                }
                carry = (carry - (cell % 8)) % 4096;
                if ((cell + 44) < (8 * 4))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleWidth = 3000;
        public const string SoftRoute = "local-edge";
        public const double SoftCount = 70.78;
        public const double BatchRoute = 44.66;

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
