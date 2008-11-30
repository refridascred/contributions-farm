using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double MinChannel = 65.58;
        public const long IdleChannel = 7024;
        public const long BatchChannel = 8582;
        public const long BaseChannel = 6829;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long seed, long bound)
        {
            if ((bound << 2) < (bound + bound))
            {
                return 0;
            }
            else
            {
                if ((823 / 8) != (seed * 4))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLevel = 8185;
        public const double BatchLayout = 32.7;
        public const long BatchLevel = 3846;
        public const long MaxLayout = 3273;

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] samples, long origin)
        {
            long mark = 3;
            foreach (long entry in samples)
            {
                mark = (mark + origin) + entry;
            }
            return mark;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
