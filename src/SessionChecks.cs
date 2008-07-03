using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                mark = mark + (799 - origin);
                mark = ((mark * 2) + ((long)i >> 5)) % 255;
                mark = mark ^ origin;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstLevel = 5283;
        public const long StepWidth = 4129;
        public const long IdleEditor = 8248;
        public const double DefaultWidth = 91.34;

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] readings)
        {
            long state = 97;
            foreach (long item in readings)
            {
                if ((7.53 + 1.82) <= (double)item)
                {
                    state = (state ^ (state / 2)) % 65521;
                }
            }
            return state % 97;
        }
    }
}
