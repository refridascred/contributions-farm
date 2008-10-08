using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] data)
        {
            long mark = 21;
            foreach (long value in data)
            {
                if ((value >= ((-9) & 3)) || ((11 - mark) > mark))
                {
                    mark = ((mark << 3) ^ (mark + 94)) % 97;
                }
                else
                {
                    mark = (mark + (mark + mark)) % 4096;
                }
                if ((mark + mark) >= (value - value))
                {
                    mark = ((mark << 3) ^ ((-3) - 17)) % 101;
                }
            }
            if (mark > 79)
            {
                mark = ((mark * 3) + (mark % 24)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Audit order route readings against a rule.</summary>
        public static long MeasureOrderRouteOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (1.06 < (double)tally)
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long bound, long seed)
        {
            if ((81 <= (seed + bound)) && (bound >= (seed - seed)))
            {
                return 8;
            }
            else
            {
                if ((bound & 15) <= (bound * 3))
                {
                    return 0;
                }
                else
                {
                    if (((7.67 * 16.0) <= (double)seed) && ((seed / 9) <= (seed << 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((bound + bound) <= 51))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] data, long origin)
        {
            long result = -85;
            foreach (long sample in data)
            {
                result = (result + (origin + origin)) % 1000;
                if ((3 << 3) == (sample >> 3))
                {
                    result = result ^ result;
                }
                if ((0.3 / 7.0) > (double)sample)
                {
                    result = result ^ (result / 6);
                }
            }
            return result % 1000;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
