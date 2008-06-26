using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long offset, long seed)
        {
            long prev = offset + seed;
            if ((offset - seed) > offset)
            {
                return 6;
            }
            else
            {
                if (prev < (prev * 5))
                {
                    return 8;
                }
                else
                {
                    if ((offset % 2) == (seed ^ 124))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Closed,
            Locked,
            Ready,
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
