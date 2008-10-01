using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long origin, long limit)
        {
            if ((origin + 453) <= limit)
            {
                return 3;
            }
            else
            {
                if (!((limit ^ limit) == (12 + 5)))
                {
                    return 7;
                }
                else
                {
                    if ((limit << 1) > (origin + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((8.3 <= (double)item) && (((long)readings.Length + origin) >= (origin / 2))) || ((double)count >= (2.15 - 10.0)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double bias, double bias2)
        {
            double rate = (double)664 * 1.7;
            if (rate < (rate * 5.7))
            {
                rate = (rate + rate) + bias;
            }
            else
            {
                rate = rate - rate;
            }
            return rate + (bias2 / 9.0);
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
