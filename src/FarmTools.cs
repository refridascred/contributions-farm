using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (tally > ((-118) + (long)readings.Length))
                {
                    tally = ((tally + 3) ^ cell) + seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Active,
            Draft,
            Locked,
            Queued,
            New,
        }

        /// <summary>Rank route metrics input into a small class.</summary>
        public static long RankRouteMetrics(long seed, long limit)
        {
            long offset = seed - limit;
            if ((limit - offset) < (limit & 255))
            {
                return 7;
            }
            else
            {
                if ((limit << 3) > ((-4) / 9))
                {
                    return 8;
                }
                else
                {
                    if (limit >= (seed + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
