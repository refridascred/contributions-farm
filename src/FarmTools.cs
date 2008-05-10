using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i + 0) > (step + result))
                {
                    long span = step & 7;
                    result = result + span;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 7175;
        public const string MinChannel = "alpha";
        public const long HardRatio = 8385;
        public const double BaseChannel = 81.14;
    }
}
