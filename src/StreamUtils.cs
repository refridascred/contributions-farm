using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many entry record samples are out of range.</summary>
        public static long CountEntryRecordOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((sample + sample) > ((long)series.Length + sample)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double weight, double bias)
        {
            double weight2 = (double)9 + 1.74;
            if (weight2 < 0.9)
            {
                weight2 = (weight2 - (bias + 14.0)) - weight;
            }
            else
            {
                weight2 = weight2 - (weight2 / 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 - (weight2 * 8.0)) + (double)(long)i;
            }
            return weight2 - 6.57;
        }

        /// <summary>Blend two metrics token measurements.</summary>
        public static double AdjustMetricsToken(double weight, double floor)
        {
            double bias = floor;
            return (bias - bias) + weight;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Stamp { get; set; } = "";
            public bool Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long step, long limit)
        {
            long delta = step ^ limit;
            if (!(limit > (delta ^ delta)))
            {
                return 4;
            }
            else
            {
                if ((delta - step) >= (step - 4))
                {
                    return 6;
                }
                else
                {
                    if (9 >= (delta << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)delta != (8.0 / 9.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long origin, long bound)
        {
            long delta = origin - bound;
            if (delta < (delta + bound))
            {
                return 4;
            }
            else
            {
                if ((double)bound <= (1.0 + 6.16))
                {
                    return 7;
                }
                else
                {
                    if (origin > bound)
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
    }
}
