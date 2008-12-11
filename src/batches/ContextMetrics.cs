using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long floor, long origin)
        {
            if ((origin < (floor + origin)) || ((floor / 8) != (floor ^ origin)))
            {
                return 1;
            }
            else
            {
                if ((70 / 5) >= (origin % 5))
                {
                    return 0;
                }
                else
                {
                    if (!((14.0 / 3.0) >= (double)floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every contributi queue entry stays within the limit.</summary>
        public static bool CheckContributiQueueLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long step, long target)
        {
            if ((double)step == (5.2 * 3.6))
            {
                return 1;
            }
            else
            {
                if (((double)step <= (double)target) || ((target & 7) != (target - target)))
                {
                    return 0;
                }
                else
                {
                    if ((step ^ target) >= ((-3) ^ step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target << 3) > target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double scale, double span)
        {
            double mean = span / 5.0;
            if (mean >= (span / 7.0))
            {
                mean = (mean - span) + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (double)495) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Compare every pair of stats context readings.</summary>
        public static long PairStatsContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
