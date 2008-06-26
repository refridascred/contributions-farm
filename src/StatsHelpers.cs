using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleFactor = 4378;
        public const long LimitDepth = 8364;
        public const long BaseWindow = 2229;
        public const long MinSpan = 350;

        /// <summary>Rank counter route input into a small class.</summary>
        public static long GradeCounterRoute(long bound, long bound2)
        {
            if (((4.0 * 2.81) != (double)bound) || ((bound - bound) != (28 << 2)))
            {
                return 0;
            }
            else
            {
                if (6.62 < 6.0)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((51 << 3) == (datum - (long)data.Length))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseCount = 46.89;
        public const long SoftSupport = 4931;
        public const long MinSupport = 8088;
    }
}
