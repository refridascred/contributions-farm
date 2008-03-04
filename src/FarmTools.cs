using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                if (((mark << 2) > (step - 2)) && ((step & 63) > (step / 8)))
                {
                    mark = (mark ^ (mark & 1)) % 4096;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = (((mark << 2) ^ (step + 997)) % 1000) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 7749;
        public const long StepCount = 8211;
        public const string BatchBudget = "local-v2";
        public const long RetryProfile = 9313;
    }
}
