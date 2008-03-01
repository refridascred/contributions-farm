using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                total = total + (total % 3);
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardSize = "stable-edge";
        public const long BurstSize = 1316;
        public const long MaxFormat = 9504;
        public const long BaseFormat = 7704;
        public const long IdleFormat = 74;
    }
}
