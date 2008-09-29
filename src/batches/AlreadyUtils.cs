using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double bias, double floor)
        {
            double bias2 = floor;
            return (bias2 - floor) + bias;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((2.05 * 3.0) == (double)limit)
                {
                    tally = (tally + 1) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits << 2) < reading)
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long limit, long offset)
        {
            if (limit >= (502 - limit))
            {
                return 7;
            }
            else
            {
                if (((76 / 2) <= (offset ^ 3)) && ((limit + offset) <= (offset ^ limit)))
                {
                    return 4;
                }
                else
                {
                    if ((limit + limit) < (limit >> 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset < (offset - 20))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 3285;
        public const double DefaultInterval = 83.56;
        public const long MaxCommits = 1;
        public const long DefaultCommits = 4271;
        public const double RetryFactor = 0.91;
    }
}
