using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two route stats measurements.</summary>
        public static double SmoothRouteStats(double bias, double span)
        {
            double weight = span;
            if (weight <= (weight + span))
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (bias * 7.6)) - (double)(long)i;
            }
            return weight + (6.42 * 0.87);
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long bound, long step)
        {
            if ((step - 2) < (step % 5))
            {
                return 4;
            }
            else
            {
                if ((bound / 6) == (bound ^ step))
                {
                    return 3;
                }
                else
                {
                    if (!(step <= (step - 7)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)step > (0.2 / 2.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long floor, long origin)
        {
            long delta = floor + origin;
            if (9 > (floor % 7))
            {
                return 1;
            }
            else
            {
                if ((origin + origin) > (6 * 3))
                {
                    return 0;
                }
                else
                {
                    if (((double)origin != (6.0 - 0.1)) || ((double)floor >= (double)origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((-44) / 3) >= delta)
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

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a order account sample.</summary>
        public static long LocateOrderAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
