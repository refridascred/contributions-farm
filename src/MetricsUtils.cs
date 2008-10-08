using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double scale, double span)
        {
            double weight = scale;
            return weight + (weight + span);
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

        /// <summary>Count the already batches entries that pass the check.</summary>
        public static long MeasureAlreadyBatchesMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading >> 4) < reading)
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }
    }
}
