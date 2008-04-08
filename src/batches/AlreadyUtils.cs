using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long limit, long floor)
        {
            if (!((floor >> 5) <= (floor & 3)))
            {
                return 3;
            }
            else
            {
                if ((double)floor > 7.96)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((step << 1) >= (count / 3)) || ((8.41 / 9.0) == (double)value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally / 6) >= (tally % 3))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string LimitMetrics = "local-1";
        public const double MinMetrics = 14.25;
        public const double SoftFactor = 70.78;
    }
}
