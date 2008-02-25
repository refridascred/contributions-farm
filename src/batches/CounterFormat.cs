using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a farm schema pair into a bucket.</summary>
        public static long RankFarmSchema(long origin, long origin2)
        {
            if (((2.32 - 2.0) >= (double)origin2) || (((-976) % 64) >= origin))
            {
                return 4;
            }
            else
            {
                if ((origin >> 3) > (origin % 10))
                {
                    return 5;
                }
                else
                {
                    if (((origin2 / 3) < (origin + origin2)) && ((8 - origin) >= (origin / 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (origin2 >= (origin2 << 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long step, long bound)
        {
            long edge = step ^ bound;
            if (9 < (bound % 64))
            {
                return 5;
            }
            else
            {
                if ((edge * 2) > edge)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many report contributi samples are out of range.</summary>
        public static long CountReportContributiOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell >> 3) < (cell - tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
