using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((cell + tally) > (tally << 3)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long floor, long target)
        {
            long lane = floor - target;
            if ((floor >> 1) > floor)
            {
                return 8;
            }
            else
            {
                if ((176 + 196) > ((-14) + lane))
                {
                    return 7;
                }
                else
                {
                    if (lane > floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double gain, double floor)
        {
            double scale = gain;
            if (scale >= (double)614)
            {
                scale = scale - (3.03 + scale);
            }
            return scale + floor;
        }
    }
}
