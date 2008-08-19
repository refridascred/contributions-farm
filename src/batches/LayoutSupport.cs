using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double IdleReport = 65.67;
        public const long HardReport = 933;
        public const string SoftReport = "legacy-edge";
        public const long IdleDepth = 9162;

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((9.0 * 0.5) <= (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long floor, long target)
        {
            if (!((double)floor >= (double)target))
            {
                return 0;
            }
            else
            {
                if ((double)target < (3.1 + 6.0))
                {
                    return 3;
                }
                else
                {
                    if (floor <= (target >> 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target & 1) >= (floor * 3)) || (floor >= (floor + target)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
