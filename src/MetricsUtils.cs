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

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long floor, long origin)
        {
            if (2 <= floor)
            {
                return 6;
            }
            else
            {
                if (((floor + floor) > (origin ^ floor)) || ((double)floor != (double)673))
                {
                    return 4;
                }
                else
                {
                    if ((origin >= (floor & 63)) || (floor <= (2 + 403)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((190 ^ floor) >= origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Retry,
            Stale,
        }
    }
}
